using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(' ')
           .Select(int.Parse).ToArray();

            int startindex = 0;
            int length = 1;
            int bestStartIndex = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    length++;
                }
                else
                {


                    if (bestLength < length)
                    {
                        bestLength = length;
                        bestStartIndex = startindex;
                    }

                    startindex = i;
                    length = 1;
                }
            }

            if (bestLength < length)
            {
                bestLength = length;
                bestStartIndex = startindex;
            }

            for (int i = bestStartIndex; i < bestStartIndex + bestLength; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }


        }
    }
}
