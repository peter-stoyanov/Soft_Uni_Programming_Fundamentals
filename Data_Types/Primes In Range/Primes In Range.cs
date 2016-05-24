using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ", FindPrimesInRange(a, b)));

        }

        static List<long> FindPrimesInRange(long start, long end)
        {
            List<long> primes = new List<long>();

            for (long i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
            
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

           return prime;
        }

    }
}
