using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_In_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            
            char[] charArray = input.ToCharArray();

            Array.Reverse(charArray);

            string reversed = new string(charArray);

            Console.WriteLine(reversed);

        }
    }
}
