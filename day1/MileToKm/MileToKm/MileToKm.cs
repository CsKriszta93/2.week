using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileToKm
{
    class MileToKm
    {
        static void Main(string[] args)
        {
            int distance = 0;
            double convertkm = 1.609;
            Console.WriteLine("Enter the distance in km:");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It's " + distance / convertkm + " miles.");
            Console.ReadLine();
        }
    }
}
