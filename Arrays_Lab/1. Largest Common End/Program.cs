using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstarr = Console.ReadLine().Split();
            string[] secondarr = Console.ReadLine().Split();

            int smallerArrayLength = Math.Min(firstarr.Length, secondarr.Length);

            int leftcounter = 0;
            leftcounter= CountCommonElements(firstarr, secondarr, smallerArrayLength);

            Array.Reverse(firstarr);
            Array.Reverse(secondarr);

            int rightcounter = 0;
            rightcounter = CountCommonElements(firstarr, secondarr, smallerArrayLength);

            Console.WriteLine(Math.Max(leftcounter,rightcounter));
            
        }

        private static int CountCommonElements(string[] firstarr, string[] secondarr, int smallerArrayLength)
        {
            int counter = 0;
            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (firstarr[i] == secondarr[i])
                {
                    counter++;
                }
            }

            return counter;
        }


    }
}
