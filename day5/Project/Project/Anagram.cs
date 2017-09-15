using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Anagram
    {
        public static bool Anagram1(string input1, string input2)
        {
             char[] chars1 = input1.ToCharArray();
             char[] chars2 = input2.ToCharArray();
             Array.Sort(chars1);
             Array.Sort(chars2);
            if (chars1.Length != chars2.Length)
             {
                return false;
             }
            for (int i = 0; i < chars1.Length; i++)
            {
                if (chars1[i] != chars2[i])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Type in a word");
            string input1 = Console.ReadLine();
            Console.WriteLine("Type in another word");
            string input2 = Console.ReadLine();

            bool isAnagram1 =  Anagram1(input1, input2);
            Console.WriteLine(isAnagram1);

            Console.ReadLine();
        }
    }
}
