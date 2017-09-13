using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    class HelloUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name + "!");
            Console.ReadLine();
        }
    }
}
