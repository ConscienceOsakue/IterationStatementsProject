using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000

            Console.WriteLine("Welcom, you are assigne 1000 Orangies. Type in the number of Orangies assign to you below! ");
            var userInput = Console.ReadLine();
            var myOrangies = int.Parse(userInput);
            var listOfMyOrangies = new List<double>();

            //A do-while loop that will decrease the number of oragies till -1000:
            do
            {

                myOrangies--;
                listOfMyOrangies.Add(myOrangies);

            } while (myOrangies >= -999);

            foreach (var orange in listOfMyOrangies)
            {
                Console.WriteLine($"{orange} orangies");
            }

            //------------End of exercise
        }
    }
}
