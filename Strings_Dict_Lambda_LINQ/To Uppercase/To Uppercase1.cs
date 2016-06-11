using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputtext = Console.ReadLine();

            int firstTag = 0;
            int secondTag = 0;
            string betweentags = "";
            string replacement = "";
            string result = "";
            string forreplacement = "";
            string inputtext2 = inputtext;

            while (inputtext.IndexOf("<upcase>") != -1)
            {
                firstTag = inputtext.IndexOf("<upcase>");
                secondTag = inputtext.IndexOf("</upcase>");
                betweentags = inputtext.Substring(firstTag+8, secondTag - firstTag-8);
                
                inputtext2 = inputtext.Remove(inputtext.IndexOf("<upcase>"), inputtext.IndexOf("</upcase>")+9- inputtext.IndexOf("<upcase>"));
                
                result = inputtext2.Insert(firstTag, betweentags.ToUpper());
                
                inputtext = result;
            }

            Console.WriteLine(result);
           

        }
    }
}
