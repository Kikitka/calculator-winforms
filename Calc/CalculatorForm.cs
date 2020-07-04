using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorFormLoad(object sender, EventArgs e)
        {
            AddButtons();
        }

        private void AddButtons()
        {
            var buttonsArray = new Button[10];

            var x = 40;
            var y = 160;
            var buttonWidth = 35;
            var buttonHeight = 35;

            var k = 0;

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (i == 0)
                    {
                        buttonWidth += 80;
                    }

                    buttonsArray[i] = new Button
                    {
                        BackColor = Color.White,
                        Text = (k++).ToString(),
                        Location = new Point(x, y),
                        Size = new Size(buttonWidth, buttonHeight)
                    };
                    buttonsArray[i].Click += EditInputLine;
                    this.Controls.Add(buttonsArray[i]);

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

        private void EditInputLine(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;

            var lineChecker = new LineChecker();
            InputLine.Text = lineChecker.EditLine(InputLine.Text, button.Text);
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

        private void EqualsButtonClick(object sender, EventArgs e)
        {
            var calculator = new Calculator();
            var lineChecker = new LineChecker();

            if (InputLine.Text.Length > 0 && lineChecker.CheckBrackets(InputLine.Text))
            {
                var result = calculator.Calculate(InputLine.Text).ToString();
                WriteHistory(InputLine.Text, result);

                InputLine.Text = result;
            }
            else
            {
                MessageBox.Show("Некорректно введены данные");
            }
        }

        private void WriteHistory(string str, string result)
        {
            CalculatorHistory.Text += str + " = " + result + "\n";

            //Очистка истории
            var history = CalculatorHistory.Text;
            var countLines = history.Count(c => c == '\n');

            if (countLines >= 10)
            {
                CalculatorHistory.Text = "";
            }
        }
    }
}
