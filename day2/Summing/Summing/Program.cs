using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing
{
    class Program
    {
        public static int Sum(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4);
        }
        static void Main(string[] args)
        {
            int num1 = 14;
            int num2 = 8;
            int num3 = 19;
            int num4 = 7;

            Console.WriteLine(Sum(num1, num2, num3, num4));
            Console.ReadLine();
        }
    }
}
