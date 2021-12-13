using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Referee
    {
        public bool isValidMove(Move move, Board board)
        {
            if (move.Row >= board.RowsNumber || move.Column >= board.ColumnsNumber)
            {
                return false;
            }
            string value = board.State[move.Row, move.Column];
            return !SymbolsEnum.isValidSymbol(value);
        }

        public bool isWinnigMove(Move move, Board board)
        {
            return isDiagonalCompleted(move, board) || isHorizonalLineCompleted(move, board) || isVerticalCompleted(move, board);
        }

        public bool isHorizonalLineCompleted(Move move, Board board)
        {
            bool isCompleted = true;
            int i = 0;
            while (isCompleted && i < board.RowsNumber)
            {
                isCompleted = board.State[move.Row, i] == move.Symbol;
                i++;
            }
            return isCompleted;
        }
        public bool isVerticalCompleted(Move move, Board board)
        {
            bool isCompleted = true;
            int i = 0;
            while (isCompleted && i < board.ColumnsNumber)
            {
                isCompleted = board.State[i, move.Column] == move.Symbol;
                i++;
            }
            return isCompleted;
        }

        public bool isDiagonalCompleted(Move move, Board board)
        {
            bool isCompleted = true;
            int i = 0;
            while (isCompleted)
            {
                isCompleted = board.State[i, i] == move.Symbol;
                i++;
            }
            if (isCompleted)
            {
                return true;
            }
            isCompleted = true;
            i = 0;
            while (isCompleted)
            {
                isCompleted = board.State[i, board.ColumnsNumber - i - 1] == move.Symbol;
                i++;
            }
            return isCompleted;
        }
    }
}
