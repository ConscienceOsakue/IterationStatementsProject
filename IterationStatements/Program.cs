using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            Console.WriteLine($"Hello, what is you name?");
            var playerName = Console.ReadLine();


            Console.WriteLine($"{playerName} your play time starts from 3 and MAX at 999.");

            Console.WriteLine($"{playerName}, type in the MAX play number to view your play list");


            var maxPlayTime = int.Parse(Console.ReadLine());
            var numOfVideoPlay = 3;
            var VideoPlayTimes = new List<double>();

            for (numOfVideoPlay = 3; numOfVideoPlay <= maxPlayTime; numOfVideoPlay += 3)
            {
                Console.WriteLine($"{numOfVideoPlay}");
            }

            //------------End of exercise
        }
    }
}
