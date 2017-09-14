using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAll
{
    class SumAll
    {
        static void Main(string[] args)
        {
            int[] ai = { 3, 4, 5, 6, 7 };
            /*foreach (int number in ai)
            {
                Console.WriteLine(number + (number +  1));
                Console.ReadLine();

            }*/

            int sum = 0;

            for (int i = 0; i < ai.Length; i++)
            {
                Console.WriteLine(sum += ai[i]);
            }
           
            Console.ReadLine();
        }
    }
}
