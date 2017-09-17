using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class GuessNumber
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("We're playing Guess my Number! You can choose the range. Where should it start?");
            int range1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Okay. Now give me the top of the range: ");
            int range2 = int.Parse(Console.ReadLine());
            Random random = new Random();
            int number = random.Next(range1, range2);
            Console.WriteLine("Enter a number between " + range1 + " and " + range2 + " : ");
            int lives = 5;
            int input = 0;

            while (input != number && lives != 0)
            {
                input = int.Parse(Console.ReadLine());
                
                if (input < number)
                {
                    Console.WriteLine("It's too low.");
                    lives--;
                    Console.WriteLine("You have " + lives + " left. Keep trying!");
                    Console.WriteLine();
                }
                else if (input > number)
                {
                    Console.WriteLine("It's too high.");
                    lives--;
                    Console.WriteLine("You have " + lives + " left. Keep trying!");
                    Console.WriteLine();
                }
                if (lives == 0)
                {
                    Console.WriteLine("Sorry, you're out of lives. Maybe next time...");
                }
                
            }
            if (input == number && lives != 0)
            {
                Console.WriteLine("Congratulations. You won!");
            }

            Console.ReadLine();
        }
    }
}
