using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingClassGuys
{
    internal class Guy
    {
        public string Name;
        public int Cash;

    public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }

    public int GiveCash(int amount)
        {
            if (amount == 99)
            {
                throw new ArgumentOutOfRangeException("better luck next time");
            }
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid ammount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }

    public void RecieveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take.");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
