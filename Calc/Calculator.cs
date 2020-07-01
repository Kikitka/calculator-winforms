using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        //Перевод в обратную польскую запись
        private List<string> ConvertToRPN(string str)
        {
            Stack<string> stack = new Stack<string>();

            Regex num = new Regex(@"\d");

            List<string> temp_str = new List<string>();

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
                        else if (ch == "(")
                        {
                            stack.Push(ch);
                        }
                        else if (CheckPriority(ch) <= CheckPriority(stack.Peek()))
                        {
                            while (stack.Count > 0 && CheckPriority(ch) <= CheckPriority(stack.Peek()))
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

        public double Calculate(string enter_str)
        {
            double result;
            var str = ConvertToRPN(enter_str);

            if (str.Count() == 1)
            {
                result = Convert.ToDouble(str[0]);
            }
            else
            {
                result = 0.0;

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
            }

            return result;
        }

        //Проверка приоритета
        private int CheckPriority(string ch)
        {
            var priority_ch = 0;

            switch (ch)
            {
                case "(":
                    priority_ch = 0;
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
        public bool CheckBrackets(string str)
        {
            var count = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    count++;
                }
                else if (str[i] == ')')
                {
                    count--;
                }
            }

            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
