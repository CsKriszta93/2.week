using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + number + "=" + number * i);
            }
            Console.ReadLine();
        }
    }
}
