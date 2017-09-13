using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementElement
{
    class IncrementElement
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5 };
            //t[2] = ++t[2];
            //t[2] += 1; 

           
            
            for (int i = 0; i < t.Length; i++)
            {
                t[i] += 1;
                Console.WriteLine(t[i]);
            }

            /*foreach (int num in t)
            {
                Console.WriteLine(num);
            }*/
            
            Console.ReadLine();

        }
    }
}
