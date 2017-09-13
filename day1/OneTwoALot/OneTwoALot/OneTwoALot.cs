using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwoALot
{
    class OneTwoALot
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;
            Console.WriteLine("Please, enter a number:");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber <= 0)
            {
                Console.WriteLine("Not enough.");
            }
            else if (inputNumber == 1)
            {
                Console.WriteLine("One");

            }
            else if (inputNumber == 2)
            {
                Console.WriteLine("Two");
            }
                
            else 
            {
                Console.WriteLine("A lot");
            }

            Console.ReadLine();
        }
    }
}
