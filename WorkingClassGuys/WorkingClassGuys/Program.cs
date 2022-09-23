using System;

namespace WorkingClassGuys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "")
                {
                    Console.WriteLine("Hello");
                    return;
                }
                if (int.TryParse(howMuch, out int amount)) //Makes sure input is an integer
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    
                    if (whichGuy == "Joe")
                    {
                        try
                        {
                            int cashGiven = joe.GiveCash(amount);
                            bob.RecieveCash(cashGiven);
                            Console.WriteLine($"Bob has {bob.Cash}");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("I always happen");
                        }
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.RecieveCash(cashGiven);
                        Console.WriteLine("Joe has " + joe.Cash);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Plaese enter an amount (or a blank line to exit).");
                }
            }

        }
    }
}