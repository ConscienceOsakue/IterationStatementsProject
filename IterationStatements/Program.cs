using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IterationStatements
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the price of the cake: ");
            if (int.TryParse(Console.ReadLine(), out int cakePrice))
            {
                Console.Write("Enter the price of the cookie: ");
                if (int.TryParse(Console.ReadLine(), out int cookiePrice))
                {
                    if (AreEqual(cakePrice, cookiePrice))
                    {
                        Console.WriteLine("The two price are equal.");
                    }
                    else
                    {
                        Console.WriteLine("The two price are not equal.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the cookie price.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the cake price.");
            }
        }

        public static bool AreEqual(int cakePrice, int cookiePrice)
        {
            return cakePrice == cookiePrice;
        }
    }
}
