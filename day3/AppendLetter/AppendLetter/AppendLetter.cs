using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLetter
{
    class AppendLetter
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            foreach (string i in far)
            {
                Console.WriteLine(i + "a");

            }
            Console.ReadLine();
        }
    }
}
