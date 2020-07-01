using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddButtons();
        }

        private void AddButtons()
        {
            Button[] but = new Button[10];

            var x = 40;
            var y = 160;
            var buttonWidth = 35;
            var buttonHeight = 35;

            var k = 0;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if(i == 0)
                    {
                        buttonWidth += 80;
                    }

                    but[i] = new Button();
                    but[i].BackColor = Color.White;
                    but[i].Text = (k++).ToString();
                    but[i].Location = new Point(x, y);
                    but[i].Size = new Size(buttonWidth, buttonHeight);
                    but[i].Click += ButtonOnClick;
                    this.Controls.Add(but[i]);

                    if (i == 0)
                    {
                        buttonWidth = 35;
                        break;
                    }

                    x += 40;
                }
                x = 40;
                y -= 40;
            }
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            if(InputLine.Text == "0")
            {
                InputLine.Text = "";
            }

            var but = (Button)sender;

            Regex num = new Regex(@"\d$");

            if (!num.IsMatch(but.Text))
            {
                if (num.IsMatch(InputLine.Text)|| InputLine.Text.EndsWith(")") || but.Text == "(")
                {
                    //Проверка правильности написания скобок
                    if (but.Text == "(")
                    {
                        if (!InputLine.Text.EndsWith(")") && !num.IsMatch(InputLine.Text))
                        {
                            InputLine.Text += but.Text;
                        }
                    }
                    else
                    {
                        InputLine.Text += but.Text;
                    }
                }
            }
            else
            {
                InputLine.Text += but.Text;
            }
        }

        private void Clear_line_Click(object sender, EventArgs e)
        {
            InputLine.Text = "";
        }

        private void Delete_symbol_Click(object sender, EventArgs e)
        {
            if (InputLine.Text.Length > 0)
            {
                InputLine.Text = InputLine.Text.Remove(InputLine.Text.Length - 1);
            }
        }

        private void Equally_but_Click(object sender, EventArgs e)
        {
            if (InputLine.Text.Length > 0)
            {
                InputLine.Text = Calculate(InputLine.Text).ToString();
            }
        }

        //Перевод в обратную польскую запись
        private List<string> Convert_to_RPN(string str)
        {
            Stack<string> stack = new Stack<string>();

            Regex num = new Regex(@"\d");

            //var temp_str = "";

            List<string> temp_str = new List<string>();

            if (Check_brackets(str))
            {
                for (var i = 0; i < str.Length; i++)
                {
                    string ch = "";
                    ch += str[i];

                    //Запись числа, в случае если оно больше 1-го символа
                    if (Char.IsDigit(str[i]) && i < str.Length - 1)
                    {
                        while (i + 1 < str.Length && Char.IsDigit(str[i + 1]))
                        {
                            ch += str[++i];
                        }
                    }

                    //Запись числа в массив
                    if (num.IsMatch(ch))
                    {
                        temp_str.Add(ch);
                    }
                    else
                    {
                        //Работа с символами
                        if (stack.Count > 0)
                        {
                            if (ch == ")")
                            {
                                while (stack.Peek() != "(")
                                {
                                    temp_str.Add(stack.Pop());
                                }
                                stack.Pop();
                            }
                            else if(ch == "(")
                            {
                                stack.Push(ch);
                            }
                            else if (Check_priority(ch) <= Check_priority(stack.Peek()))
                            {
                                while (stack.Count > 0 && Check_priority(ch) <= Check_priority(stack.Peek()))
                                {
                                    temp_str.Add(stack.Pop());    
                                }
                                stack.Push(ch);
                            }
                            else
                            {
                                stack.Push(ch);
                            }
                        }
                        else
                        {
                            stack.Push(ch);
                        }
                    }
                }

                //Запись оставшихся символов из стека в массив
                if (stack.Count > 0)
                {
                    while (stack.Count != 0)
                    {
                        temp_str.Add(stack.Pop());
                    }
                }

                return temp_str;
            }
            else
            {
                throw new Exception("Неверное к-во введённых скобок");
            }
        }

        //Проверка приоритета символа
        private int Check_priority(string ch)
        {
            var priority_ch = 0;
            
            switch(ch)
            {
                case "(": priority_ch = 0;
                    break;
                case "+":
                case "-":
                    priority_ch = 1;
                    break;
                case "*":
                case "/":
                    priority_ch = 2;
                    break;
            }

            return priority_ch;
        }

        //Проверка на правильное к-во введённых символов
        private bool Check_brackets(string str)
        {
            var count = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    count++;
                }
                else if(str[i] == ')')
                {
                    count--;
                }
            }

            if(count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double Calculate(string enter_str)
        {
            var str = Convert_to_RPN(enter_str);
            double result = 0.0;

            Regex num = new Regex(@"\d");

            Stack<string> stack = new Stack<string>();
            if (str.Count > 1)
            {
                for (var i = 0; i < str.Count; i++)
                {
                    if (num.IsMatch(str[i]))
                    {
                        stack.Push(str[i]);
                    }
                    else
                    {
                        var num1 = Convert.ToDouble(stack.Pop());
                        var num2 = Convert.ToDouble(stack.Pop());

                        switch (str[i])
                        {
                            case "+":
                                result = num1 + num2;
                                break;
                            case "-":
                                result = num2 - num1;
                                break;
                            case "*":
                                result = num1 * num2;
                                break;
                            case "/":
                                result = num2 / num1;
                                break;
                        }

                        stack.Push(result.ToString());
                    }
                }
            }

            Write_history(enter_str, result.ToString());

            return result;
        }

        private void Write_history(string str, string result)
        {
            CalcHistory.Text += str + " = " + result + "\n";

            //Очистка истории
            var s = CalcHistory.Text;
            var n = s.Count(c => c == '\n');

            if(n >= 10)
            {
                CalcHistory.Text = "";
            }
        }
    }
}
