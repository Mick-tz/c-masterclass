using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class SymbolsEnum
    {
        public const string cross = "X";
        public const string circle = "O";

        public static bool isValidSymbol(string symbol)
        {
            return symbol == cross || symbol == circle;
        }
    }
}
