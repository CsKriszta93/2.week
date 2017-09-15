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
            int[] s = { 1, 2, 3, 8, 5, 6 };
          
            int fourth = 4;
            s[3] = fourth;

            foreach (int i in s)
            {
                Console.WriteLine(i);

            }

            Console.ReadLine();

            





            Console.WriteLine(s[3]);
            Console.ReadLine();
        }
    }
}
