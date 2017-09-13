using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAll
{
    class PrintAll
    {
        static void Main(string[] args)
        {

            int[] af = { 4, 5, 6, 7 };
            foreach (int num in af)
            {
                Console.WriteLine(num);
                Console.ReadLine();
            }
        }
    }
}
