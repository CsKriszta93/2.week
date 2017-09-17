using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamentricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Enter a number: ");
            int repeat = int.Parse(Console.ReadLine());
            int Sum = 0;
            int Average = 0;

            Console.WriteLine("Enter " + repeat + " numbers: ");
            for (int i = 0; i < repeat; i++)
            {
                Sum += int.Parse(Console.ReadLine());
                Average = Sum / repeat;
                
            }

            Console.WriteLine("Sum: " + "{0} " + "Average: " + "{1} ", Sum, Average);
            Console.ReadLine();
        }
    }
}
