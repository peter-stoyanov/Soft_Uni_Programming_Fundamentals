using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] middleElem = new int[2 * k];
            int[] foldedElem1 = new int[k];
            int[] foldedElem2 = new int[k];
            int[] summedElem = new int[2 * k];

            for (int i = k; i <= 3*k-1; i++)
            {
                middleElem[i-k] = numbers[i];
            }

            for (int i = 0; i <= k-1; i++)
            {
                foldedElem1[i] = numbers[i];
            }
            for (int i = 0; i <= k-1; i++)
            {
                foldedElem2[i] = numbers[3 * k +i];

            }

            Array.Reverse(foldedElem1);
            Array.Reverse(foldedElem2);

            int[] folded = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                folded[i] = foldedElem1[i];
            }
            for (int i = k; i < 2*k; i++)
            {
                folded[i] = foldedElem2[i-k];
            }

            for (int i = 0; i < 2*k; i++)
            {
                summedElem[i] = folded[i] + middleElem[i];
            }

            foreach (int number in summedElem)
            {
                Console.Write("{0} ",number);
            }

        }
    }
}
