using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime1
{
    class IsPrime2
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            IsPrime(num);
        }

        private static bool IsPrime(long num)
        {
            var prime = (num > 1);
            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
            return prime;
        }

    }
}
