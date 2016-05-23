using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            char symbol = char.Parse(Console.ReadLine());

            bool isVowel = "aeiouAEIOU".IndexOf(symbol) >= 0;

            bool isDigit = (symbol >= '0' && symbol <= '9');

            if (isVowel == true)
            {
                Console.WriteLine("vowel");
            }
            else if (isDigit == true)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
