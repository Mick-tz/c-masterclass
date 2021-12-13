using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Game
    {
        private Player player1;
        private Player player2;
        private Referee referee;
        private Board board = new Board();
        private UI ui;
        private bool on = true;
        private bool playerHasWon = false;

        public void startGame()
        {
            ui.renderStartMessage();
            string renderRulesResponse = Console.ReadLine();
            if (renderRulesResponse == "Y")
            {
                ui.renderRules();
            }
            ui.requestForName();
            string player1Name = Console.ReadLine();
            this.player1 = new Player(player1Name, "O");
            ui.renderWelcomeMsg(player1Name, "O");
            ui.requestForName();
            string player2Name = Console.ReadLine();
            while (player1Name == player2Name)
            {
                ui.renderSameNameMsg();
                player2Name = Console.ReadLine();
            }
            this.player2 = new Player(player2Name, "X");
            ui.renderWelcomeMsg(player2Name, "X");
            while (on)
            {
                Console.WriteLine();
                ui.RenderBoard(this.board);
                int turn = 0;
                while (!this.playerHasWon)
                {
                    if (turn % 2 == 0)
                    {
                        ui.requestForMove(player1Name);
                        string 
                        if (referee.isValidMove())
                        {

                        }
                    }

                    turn++;
                }

                ui.renderEndGameMessage("");
            }
        }
    }
}
