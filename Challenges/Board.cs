using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Board
    {
        private string[,] state;
        private const int ROWS_NUMBER = 3;
        private const int COLUMNS_NUMBER = 3;

        #region Properties
        public int RowsNumber { get { return ROWS_NUMBER; } }
        public int ColumnsNumber { get { return COLUMNS_NUMBER; } }
        public int TotalBoxes { get { return ROWS_NUMBER * COLUMNS_NUMBER; } }
        public string[,] State { get { return this.state; } set { this.state = value; } }
        #endregion

        public Board(string[,] state)
        {
            this.state = state;
        }
        public Board()
        {
            this.ResetState();
        }

        public void ResetState()
        {
            for (int i = 0; i < this.TotalBoxes; i++)
            {
                int row = i / this.RowsNumber;
                int column = i % this.ColumnsNumber;
                string boxValue = Convert.ToString(i + 1);
                Move move = new Move(row, column, boxValue);
                setValue(move);
            }
        }

        public void setValue(Move move) { this.state[move.Row, move.Column] = move.Symbol;  }
    }
}
