using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input / 2 - 1; i++)
            {
                for (int j = 1; j < input - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write('*');
                    Console.Write(" ");
                }
                Console.WriteLine();

            }

            for (int i = input / 2; i >= 0;  i--)
            {
                for (int j = 1; j < input - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write('*');
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
