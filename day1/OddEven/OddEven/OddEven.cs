using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;
            Console.WriteLine("Please, enter a number:");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }

            Console.ReadLine();
        }
    }
}
