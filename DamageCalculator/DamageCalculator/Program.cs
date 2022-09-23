using System;

namespace DamageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var swordDamage = new SwordDamage();
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("0 for no magic/flaming, 1 for Magic, 2 for flaming, 3 for both, anything else to quit");
                char key = Console.ReadKey(false).KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                
                swordDamage.Roll = roll;
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');

                Console.WriteLine($"Rolled {roll} for {swordDamage.Damage} HP of damage");
            }

                
        }
    }
}