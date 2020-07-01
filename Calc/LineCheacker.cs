using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calc
{
    class LineCheacker
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
                            if (!inputLine.EndsWith("("))
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
    }
}
