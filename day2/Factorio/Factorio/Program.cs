using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    class Program
    {
        public static int Factorio(int num)
        {
            if (num <= 1)
                return 1;
            return num * Factorio(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Int32.Parse(Console.ReadLine());
            {
                Console.WriteLine(Factorio(num));
                Console.ReadLine();
            }

        }
       
        
        
        
    }
}
