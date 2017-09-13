using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[6];
            s[0] = 1;
            s[1] = 2;
            s[2] = 3;
            s[3] = 8;
            s[4] = 5;
            s[5] = 6;

            int fourth = 4;
            s[3] = fourth;

            Console.WriteLine(s[3]);
            Console.ReadLine();

            





            Console.WriteLine(s[3]);
            Console.ReadLine();
        }
    }
}
