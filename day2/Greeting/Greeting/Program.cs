using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program

    {
        public static string greet(string al)
        {
            return ("Greetings, dear " + al);
            
        }
        static void Main(string[] args)
        {
            string al = ("Greenfox");
            Console.WriteLine(greet(al));
            Console.ReadLine();

        }
    }
}
