using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRealNumbers
{
    class CompareRealNumbers
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(double.Parse);

            var orderedGroups = inputNums.OrderBy(x => x);
            var groupedGroups = orderedGroups.GroupBy(item => item);

            foreach (var group in groupedGroups)
            {
                Console.WriteLine(string.Format("{0} -> {1}", group.Key, group.Count()));
            }
            
        }
    }
}
