using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggest = GetMax(a, b);
            biggest = GetMax(biggest, c);

            Console.WriteLine(biggest);
        }


        static int GetMax(int x, int y)
        {

            int max = x;
            if (y > max)
            {
                max = y;
            }

            return max;

        }


    }
}
