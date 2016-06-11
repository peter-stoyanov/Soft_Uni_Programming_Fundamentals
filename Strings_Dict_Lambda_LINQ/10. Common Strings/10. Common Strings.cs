using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Common_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();

            char[] text1Tochar = text1.ToCharArray();
            char[] text2Tochar = text2.ToCharArray();

            char[] intersect = text1Tochar.Intersect(text2Tochar).ToArray();

            if (intersect.Length != 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
