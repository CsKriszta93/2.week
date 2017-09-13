using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Swap
    {
        static void Main(string[] args)
        {
            var a = 123;
            var b = 526;

            if (a < b)
            {
                var temp1 = a;
                a = b;
                b = temp1;

            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
            
        }
    }
}
