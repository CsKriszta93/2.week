using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };
            for (int i = aj.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(aj[i]);
            }

            Console.ReadLine();
        }
    }
}
