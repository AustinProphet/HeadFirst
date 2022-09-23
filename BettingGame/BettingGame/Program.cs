using System;

namespace BettingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = .75;
            Guy player = new Guy() { Cash = 100, Name = "The Player" };

            while (player.Cash > 0)
            {
                
                Console.WriteLine("Welcome to the Casino! The odds are " + odds);
                player.WriteMyInfo();
                Console.Write("How much do you want to bet?");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            player.RecieveCash(winnings);
                            Console.WriteLine("You win " + winnings + "!");
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Pelase enter a vaild number");
                  
                }
            }
            Console.WriteLine("The house always wins");
        }
    }
}