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
            var button = (Button)sender;

            LineCheacker lineCheacker = new LineCheacker();
            InputLine.Text = lineCheacker.EditLine(InputLine.Text, button.Text);
        }

        private void ClearLineClick(object sender, EventArgs e)
        {
            InputLine.Text = "";
        }

        private void DeleteSymbolClick(object sender, EventArgs e)
        {
            if (InputLine.Text.Length > 0)
            {
                InputLine.Text = InputLine.Text.Remove(InputLine.Text.Length - 1);
            }
        }

        private void EquallyButClick(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (InputLine.Text.Length > 0 && calculator.CheckBrackets(InputLine.Text))
            {
                InputLine.Text = calculator.Calculate(InputLine.Text).ToString();
            }
            else
            {
                MessageBox.Show("Некорректно введены данные");
            }
        }

        private void WriteHistory(string str, string result)
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
