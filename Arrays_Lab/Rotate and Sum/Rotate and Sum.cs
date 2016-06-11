using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sumOfRotations = new int[numbers.Length];

            for (int currentrotation = 0; currentrotation < rotations; currentrotation++)
            {
                int lastElement = numbers[numbers.Length - 1];

                for (int currentElement = numbers.Length -1 ; currentElement > 0; currentElement--)
                {
                    numbers[currentElement] = numbers[currentElement - 1];
                }
                numbers[0] = lastElement;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sumOfRotations[i] += numbers[i];
                }

            }

            Console.WriteLine(String.Join(" ",sumOfRotations));
            


        }
    }
}
