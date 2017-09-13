using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };
            string swap1 = abc[0];
            string swap2 = abc[2];
            abc[2] = swap1;
            abc[0] = swap2; 

            foreach (string i in abc)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

           
        }
    }
}
