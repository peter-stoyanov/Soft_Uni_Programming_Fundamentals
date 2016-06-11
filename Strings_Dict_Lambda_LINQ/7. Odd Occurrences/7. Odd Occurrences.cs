using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().ToLower().Split(' ');

            var dictResults = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                if (dictResults.ContainsKey(word))
                {
                    dictResults[word]++;
                }
                else
                {
                    dictResults.Add(word,1);
                }
            }

            var filtered = dictResults.Where(k => k.Value % 2 !=0);

            filtered = filtered.ToDictionary(i => i.Key, i => i.Value);

            
            Console.WriteLine(String.Join(", ",filtered.Select(x => x.Key)));


        }
    }
}
