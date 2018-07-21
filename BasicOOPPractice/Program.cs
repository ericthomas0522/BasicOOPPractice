using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Task is to write a dice rolling game using an instance of the random class.
            //Early practice with using OOP
            Console.WriteLine("How many 6 sided dice would you like to roll? ");
            var userInput = Console.ReadLine();
            int numberOfDice = Convert.ToInt32(userInput);
            int dieRoll = random.Next(6) + 1;
            int total = 0;

            //Unsure if this is correct because numbers like 13 or 17 aren't showing up.
            //After reading more this may have to do with the random instance I am using for this exercise.

            for (int x = 0; x < numberOfDice; x++)
            {
                total = total + dieRoll;
            }

            Console.WriteLine("Your total is " + total);
            Console.ReadLine();
        }
    }
}
