using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            bool boolvar = Convert.ToBoolean(input);

            if (boolvar)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
