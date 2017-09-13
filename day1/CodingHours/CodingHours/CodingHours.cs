using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingHours
{
    class CodingHours
    {
        static void Main(string[] args)
        {
            int codinghours = 6;
            int weeks = 17;
            int workingdays = 5;

            Console.WriteLine((weeks * workingdays) * codinghours);

            Console.ReadLine();
        }
    }
}
