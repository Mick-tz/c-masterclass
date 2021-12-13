using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Move
    {
        private int row;
        private int column;
        private string symbol;

        public int Row { get { return this.row; } }
        public int Column { get { return this.column; } }
        public string Symbol { get { return this.symbol; } }


        public Move(int row, int column, string symbol)
        {
            this.row = row;
            this.column = column;
            this.symbol = symbol;
        }

    }
}
