using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method to check whether a given number is even or odd.

            var x = 2;

            Console.WriteLine("Type in any number and i will guess if it's an even or odd number.");

            Console.WriteLine("Enter a number:");
            

            var userInput = int.Parse(Console.ReadLine());


            if (userInput % x == 0)
            {

                Console.WriteLine("Guessed it! It's an Even number.");
            }

            else
            {
                Console.WriteLine("Got you, is am Odd number!");
              
            }
             
        }
    }
}
