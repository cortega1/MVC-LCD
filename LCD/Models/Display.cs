using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCD.Models
{
    public class Display
    {
        public string number { get; set; }
        public string[,] charNumbers = new String[3, 10] {
            { "._.", "...", "._.", "._.", "...", "._.", "._.", "._.", "._.", "._." },
            { "|.|", "..|", "._|", "._|", "|_|", "|_.", "|_.", "..|", "|_|", "|_|" },
            { "|_|", "..|", "|_.", "._|", "..|", "._|", "|_|", "..|", "|_|", "..|" }
        };

        public string GetLCDrepresentation()
        {
            int numberLenght = number.Length;
            string line = "";
            for (int i = 0; i < 3; i++)
            {
                line += getStructureLine(i, numberLenght) + Environment.NewLine;
            }
            return line;
        }

        private string getStructureLine(int lineNumber, int numberLenght)
        {
            int digit = 0;
            string line = "";
            for (int o = 0; o < numberLenght; o++)
            {
                digit = Int32.Parse(number[o].ToString());
                line += charNumbers[lineNumber, digit];
                line += "   ";
            }

            return line;
        }
    }
}
