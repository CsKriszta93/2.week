using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Anagram
    {
        public static bool Anagram(string a, string b)
        {
         Console.WriteLine("Type in a word");
         string Input1 = Console.ReadLine();
         Console.WriteLine("Type in another word");
         string Input2 = Console.ReadLine();
         char[] chars1 = Input1.ToCharArray();
         char[] chars2 = Input2.ToCharArray();
         Array.Sort(chars1, chars2);
            for (int i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] != chars2[i])
                    return false;
                if (chars1 == chars2 && chars1[i] != chars2[i])
                    return true;
            }
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine());
            Console.ReadLine();
        }
    }
}
