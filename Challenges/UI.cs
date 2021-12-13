using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class UI
    {
        private string GetLine(int length)
        {
            string line = "";
            for (int i = 0; i < length; i++)
            {
                line += "_";
            }
            return line;
        }

        private string GetValuesLine(int[] values)
        {
            string line = "";
            return line;
        }
        public void RenderBoard(Board board)
        {
            string[,] state = board.State;
            string renderedBoard = $@"
            current state of the board is:

                           |               |
             {state[0, 0]} | {state[0, 1]} | {state[0, 2]}
            _______________|_______________|______________
                           |               |
             {state[1, 0]} | {state[1, 1]} | {state[1, 2]}
            _______________|_______________|______________
                           |               |
             {state[2, 0]} | {state[2, 1]} | {state[2, 2]}
                           |               |
            ";
            Console.WriteLine(renderedBoard);
        }

        public void requestForMove(string playerName)
        {
            Console.WriteLine($"{playerName}, please choose a box:");
        }

        public void requestForName()
        {
            Console.WriteLine("Please, introduce your name now: ");
        }
        public void renderSameNameMsg()
        {
            Console.WriteLine("Sorry, players cannot have the same name, please give me another name: ");
        }
        public void renderWelcomeMsg(string playerName, string symbol)
        {
            string symbolType = symbol == "O" ? "circles" : "crosses";
            Console.WriteLine($"Welcome {playerName}, you will be playing {symbolType}.");
        }

        public void renderStartMessage()
        {
            Console.WriteLine("Starting a new Game...");
            Console.WriteLine("Would you like to read the rules? (Y/n):");
        }

        public void renderRules() { Console.WriteLine(@"lorem ipsum..."); }

        public void renderEndGameMessage(string winnerName)
        {
            Console.WriteLine($"Congratulations {winnerName}, you have won!!");
            Console.WriteLine("Would you like to play a new game?(Y/n):");
        }
    }
}
