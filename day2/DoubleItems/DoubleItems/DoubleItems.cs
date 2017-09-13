using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleItems
{
    class DoubleItems
    {
        static void Main(string[] args)
        {
            int[] ag = { 3, 4, 5, 6, 7 };
            foreach(int num in ag)
            {
                Console.WriteLine(num*2);
                Console.ReadLine();
            }
        }
    }
}
