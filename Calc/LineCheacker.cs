using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calc
{
    class LineChecker
    {
        public string EditLine(string inputLine, string inputSymbol)
        {
            Regex infinity = new Regex("[∞]");

            if (inputLine == "0" || infinity.IsMatch(inputLine))
            {
                inputLine = "";
            }

            if (inputLine.Length < 20)
            {

                Regex num = new Regex(@"\d$");

                if (!num.IsMatch(inputSymbol))
                {
                    if (num.IsMatch(inputLine) || inputLine.EndsWith(")") || inputSymbol == "(")
                    {
                        //Проверка правильности написания скобок
                        if (inputSymbol == "(")
                        {
                            if (!inputLine.EndsWith(")") && !num.IsMatch(inputLine))
                            {
                                inputLine += inputSymbol;
                            }
                        }
                        else if (inputSymbol == ")")
                        {
                            if (!inputLine.EndsWith("(") && !CheckBrackets(inputLine))
                            {
                                inputLine += inputSymbol;
                            }
                        }
                        else
                        {
                            inputLine += inputSymbol;
                        }
                    }
                }
                else
                {
                    inputLine += inputSymbol;
                }
            }

            return inputLine;
        }

        //Проверка на правильное к-во введённых символов
        public bool CheckBrackets(string str)
        {
            var countBrackets = 0;

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    countBrackets++;
                }
                else if (str[i] == ')')
                {
                    countBrackets--;
                }
            }

            if (countBrackets == 0)
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
