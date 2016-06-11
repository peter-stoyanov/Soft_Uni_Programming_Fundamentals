using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Fit_String_in_20_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();

            if (inputWord.Length < 20)
            {
                string outputWord = inputWord.PadRight(20, '*');
                Console.WriteLine(outputWord);
            }
            else
            {
                string output = inputWord.Substring(0, 20);
                Console.WriteLine(output);
            }


        }
    }
}
