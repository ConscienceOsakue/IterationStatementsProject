using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        public static void Main(string[] arge)
        {
            //Write a method to check if an integer(from the user) is in the range -10 to 10.

            

            var listOfNumber = new List<int>();
            for(var num = -10; num <= 10; num++)
            {
                listOfNumber.Add(num);

            }
            Console.WriteLine("Type your number");
            var userInput = int.Parse(Console.ReadLine());

            if (listOfNumber.Contains(userInput))
            {
                Console.WriteLine($"{userInput} is in range of -10 to 10.");
            }
            else 
            { 
                Console.WriteLine($"{userInput} is not found in the range of -10 to 10.");
            }

        }
    }
}
