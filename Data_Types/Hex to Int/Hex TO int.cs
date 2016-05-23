using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex_to_Int
{
    class Program
    {
        static void Main(string[] args)
        {


            string hexvar = Console.ReadLine();

            int hexconverted = Convert.ToInt32(hexvar, 16);

            Console.WriteLine(hexconverted);
        }
    }
}
