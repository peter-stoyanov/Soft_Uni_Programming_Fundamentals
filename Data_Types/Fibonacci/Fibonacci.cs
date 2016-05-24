using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(input));

        }


        static int Fib(int n)
        {

            int fibonacci = 1;
            int a = 1;
            int b = 1;


            if (n == 0 || n==1)
            {
                return fibonacci;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    fibonacci = a + b;
                    a = b;
                    b = fibonacci;

                }

                return fibonacci;
            }
        }
    }
}
