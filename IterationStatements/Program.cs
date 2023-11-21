using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method to read the age of a candidate and determine whether they can vote.
            // Hint: use Parse()... or the safer TryParse() for an extra challenge!!

            Console.WriteLine("What is your name?");
            var candidateName = Console.ReadLine();

            Console.WriteLine($"How old are you {candidateName}");
            var candidateAge = int.Parse(Console.ReadLine());

            if (candidateAge >= 18)
            {
                Console.WriteLine($"{candidateName} You can vote!");

            }
            else
            {
                Console.WriteLine($"Sorry {candidateName} you are not 18 or older hence you can't vote!");

            }
        }
         
        }
}
