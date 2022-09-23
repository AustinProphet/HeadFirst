using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLoGame
{
    public static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random Random = new Random();
        private static int currentNumber = Random.Next(1,11);
        private static int pot = 10;

        public static int GetPot() { return pot; }

        public static void Guess(bool higher)
        {
            int nextNumber = Random.Next(0,MAXIMUM+1);
            if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"The current number is {currentNumber}");
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
            {
                Console.WriteLine($"The number is at least {half}");
            }
            else
            {
                Console.WriteLine($"The number is at most {half}");
            }
            pot--;
        }
    }
}
