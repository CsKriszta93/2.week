using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appenda
{
    class Program
    {
        public static string AppendA(string am)
        {
        return (am + "a");
        
        }

        static void Main(string[] args)
        {
        string am = "kuty";

        Console.WriteLine(AppendA(am));
        Console.ReadLine();

        }
    }
}
