using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                       .Split(' ')
                       .Select(int.Parse)
                       .ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine($"{{ {nums[0]} }}");
            }
            else if (nums.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {nums[nums.Length/2 -1]} {nums[nums.Length/2]} }}");
            }
            else
            {
                int i = (int)(Math.Floor(nums.Length / 2.0)) -1;
                Console.WriteLine($"{{ {nums[i]} {nums[i+1]} {nums[i + 2]} }}");
            }
        }
    }
}
