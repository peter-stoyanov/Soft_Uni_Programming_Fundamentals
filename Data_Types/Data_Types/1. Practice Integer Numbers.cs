using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            long num = long.Parse(Console.ReadLine());
            //var num_2 = 0;

            if (num < 2147483647)
            {
                int num_2 = (int)num;
                Console.WriteLine(num_2);
            }
            else if (num < 32767)
            {
                short num_2 = (short)num;
                Console.WriteLine(num_2);
            }
            else if (num < 127)
            {
                byte num_2 = (byte)num;
                Console.WriteLine(num_2);
            }
            else
            {
                long num_2 = num;
                Console.WriteLine(num_2);
            }

            


        }
    }
}
