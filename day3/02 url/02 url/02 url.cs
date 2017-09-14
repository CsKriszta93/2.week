using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_url
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            string replace = url.Replace("bots", "odds");

            StringBuilder https = new StringBuilder(replace);
            https.Insert(5, ':');

            Console.WriteLine(https);
            Console.ReadLine();
        }
    }
}
