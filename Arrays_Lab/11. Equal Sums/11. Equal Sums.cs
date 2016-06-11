using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
           .Select(int.Parse).ToArray();

            bool isIndexFound = false;

            for (int currentelement = 0; currentelement < numbers.Length; currentelement++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int i = currentelement +1; i < numbers.Length; i++)
                {
                    sumRight += numbers[i];
                }
                for (int i = 0; i < currentelement; i++)
                {
                    sumLeft += numbers[i];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(currentelement);
                    isIndexFound = true;
                    break;
                }
            }

            if (!isIndexFound)
            {
                Console.WriteLine("no");
            }


        }
    }
}
