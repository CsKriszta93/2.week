using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int girls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int boys = Convert.ToInt32(Console.ReadLine());

            if (girls == boys && girls + boys >= 20)
            {
                Console.WriteLine("The party is exellent");
            }
            else if (girls + boys > 20 && girls != boys)
            {
                Console.WriteLine("Quite cool party!");

            }
            else if (girls + boys < 20)
            {
                Console.WriteLine("Average party.");
            }
            else if (girls == 0)
            {
                Console.WriteLine("Sausage Party.");
            }
            else
            {
                Console.WriteLine("Lame.");
            }
            Console.ReadLine();
            
        }
    }
}
