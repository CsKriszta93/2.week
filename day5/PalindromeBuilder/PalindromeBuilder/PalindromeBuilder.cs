using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a word");
            string input = Console.ReadLine();
            Console.WriteLine(CreatePalindrome(input));
            Console.ReadLine();
        }

    static public string CreatePalindrome(string input)
        {
            string palindrome = input;
            
            for (int i = 0; i < input.Length; i++)
            {
                palindrome += input[input.Length - i - 1];
            }
            return palindrome;
            
        }
    }
}
