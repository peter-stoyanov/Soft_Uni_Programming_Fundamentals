using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            string hex_number = input.ToString("X");

            Console.WriteLine(hex_number);

            string bin_number = Convert.ToString(input, 2);

            Console.WriteLine(bin_number);

        }
    }
}
