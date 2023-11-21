using System;
using System.Collections.Generic;
using System.Net.Security;

namespace IterationStatements
{
    class Program
    {
        public static string CheckNumber(double favoriteNum)
        {
       
            //Write a method to check whether a given number is positive or negative.

            if (favoriteNum > 0)
            {
                return "Positive";
            }
            else if (favoriteNum <= 0)
            {
                return "Negative";
            }
            else
            {
                return "Time OUT!";
            }
        }
        static void Main()
        {
            Console.WriteLine("Hello, type in you favorite number, lets check if it's positive or negative?");
            var favoriteNum = double.Parse(Console.ReadLine());
            var result = CheckNumber(favoriteNum);
            Console.WriteLine($"The number {favoriteNum} is {result}.");


        }
    }

}
 