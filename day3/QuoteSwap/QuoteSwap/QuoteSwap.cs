using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteSwap
{
    class QuoteSwap
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            list[2] = "cannot";
            list[5] = "do";
            
            string[] quoteArr = list.ToArray();
            string wholeQuote = string.Join(" ", quoteArr);
            Console.WriteLine(wholeQuote);
            Console.ReadLine();


        }
    }
}
