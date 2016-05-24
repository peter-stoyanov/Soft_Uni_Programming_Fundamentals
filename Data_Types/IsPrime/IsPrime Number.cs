using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class IsPrimeNumber
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            if (IsPrime(input))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        static Boolean IsPrime(int number)
        {
            double boundary = Math.Ceiling(Math.Sqrt((double)number));

            
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0) return false;
            }

            return true;    

         }
        

    }
}
