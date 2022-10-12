using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectUwU
{
    internal class Game
    {
        public static void NewGame()
        {
            Player player1 = new Player();
            Player player2 = new Player();
            bool isGameRunning = true;
            while (isGameRunning == true) {
                player1.Score += Dice.RollDice();
                player2.Score += Dice.RollDice();
                if (player1.Score > 50)
                    player1.Score = 25;
                if (player2.Score > 50)
                    player2.Score = 25;
                if (player1.Score == 50 || player2.Score == 50)
                {
                    Console.WriteLine("Partie terminée !");
                    isGameRunning = false;
                }

                    Console.WriteLine(player1.Score);
                Console.WriteLine(player2.Score);
                Console.ReadLine();
            }
        }
    }
}
