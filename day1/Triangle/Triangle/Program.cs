using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int row = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
