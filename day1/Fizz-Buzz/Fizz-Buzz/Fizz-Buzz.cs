using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for ( ;  i <= 100; i++)
            {
                Console.WriteLine(i);
            }
                if (i % 3 == 0)
                {
                    Console.WriteLine("fuzz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else (i % 5 == 0 && i % 3 == 0)
                { 
                    Console.WriteLine("fuzzbuzz");

                }

            Console.ReadLine();

        
        }
    }
}
