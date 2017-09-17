using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int number = 8;
            Console.WriteLine("I thought of a number. Can you guess it? Enter your guess: ");
            int input = 0;

            while (input != number)
            {
                input = int.Parse(Console.ReadLine());
                if (input < number)
                {
                    Console.WriteLine("The number is higher. Guess again: ");
                    Console.WriteLine();
                }
                else if (input > number)
                {
                    Console.WriteLine("The number is lower. Guess again: ");
                    Console.WriteLine();
                }
            }
            if (input == number)
            {
                Console.WriteLine("You guessed it! It was the number 8.");
            }

            Console.ReadLine();
        }
    }
}
