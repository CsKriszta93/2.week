using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimals = { "kuty", "macsk", "cic" };

            foreach (string animal in nimals)
            {
                Console.WriteLine(animal + "a");
                Console.ReadLine();
            }
        }
    }
}
