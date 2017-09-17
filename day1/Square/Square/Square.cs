using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Square
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write("%");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
                /*Console.Write("%");
                for (int k = 0; k < j - 2; k++)
                {
                    Console.Write(" ");
                    Console.Write("%");
                }*/
                
                
            

        }
    }
}
