using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Player
    {
        private string name;
        private string symbol;

        public string Symbol { get { return this.symbol; } }
        public string Name => name;

        public Player(string name, string symbol)
        {
            if (!SymbolsEnum.isValidSymbol(symbol))
            {
                throw new Exception("Invalid symbol for player");
            }
            this.name = name;
            this.symbol = symbol;
        }
    }
}
