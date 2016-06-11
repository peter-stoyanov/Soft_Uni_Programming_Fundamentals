using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] wordarray = word.ToCharArray();

            Array.Reverse(wordarray);

            string reversed = new string(wordarray);

            Console.WriteLine(reversed);


        }
    }
}
