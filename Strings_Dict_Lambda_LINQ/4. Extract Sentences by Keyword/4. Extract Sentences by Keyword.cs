using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {

            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();

            char[] separators = ".!?".ToCharArray();

            var sentences = text.Split(separators);
            var trimmedsentences = sentences
                                    .Select(x => x.Trim(punctuation))
                                    .Select(x => x.Trim());

            foreach (var sentence in sentences)
            {
                string[] wordsinsentence = sentence.Split(' ').ToArray();
                foreach (var word in wordsinsentence)
                {
                    if (string.Compare(keyword,word) == 0)
                    {
                        Console.WriteLine(sentence);
                        break;
                    }
                }
            }
            

        }
    }
}
