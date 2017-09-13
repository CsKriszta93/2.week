using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableMutation
{
    class VariableMutation
    {
        static void Main(string[] args)
        {
            int a = 3;
        
            Console.WriteLine(a+=10);
            Console.ReadLine();

            int b = 100;
            Console.WriteLine(b-=7);
            Console.ReadLine();

            int c = 44;
            Console.WriteLine(c*=2);
            Console.ReadLine();

            int d = 125;
            Console.WriteLine(d /=5);
            Console.ReadLine();

            int e = 8;
            Console.WriteLine(e*(e*=8));
            Console.ReadLine();

            int f1 = 123;
            int f2 = 345;

            if (f1 > f2)
            {
                Console.WriteLine(true);
            }
            else
            { 
                Console.WriteLine(false);
            }
            Console.ReadLine();

            int g1 = 350;
            int g2 = 200;

            if ((g2*2) > g1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
