using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesLonger
{
    class TakesLonger
    {
        static void Main(string[] args)
        {
            string quote = "\"Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.\"";
            string quote2 = " always takes longer than";
            StringBuilder wholeQuote = new StringBuilder(quote);
            wholeQuote.Insert(21, quote2);



            Console.WriteLine(wholeQuote);
            Console.ReadLine();
        }
    }
}
