using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random();

        /// <summary>
        /// Picks a number of cards and returns them.
        /// </summary>
        /// <param name="numberOfCards"></param>
        /// <returns></returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";

            //Random random = new Random();
            //double[] randomDoubles = new double[20];
            //for (int i = 0; i < 20; i++)
            //{
            //    double value = random.NextDouble();
            //    randomDoubles[i] = value;
            //}
        }

        private static string RandomValue()
        {
            
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
