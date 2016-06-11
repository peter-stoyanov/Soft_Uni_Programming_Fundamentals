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
            //string replacement = "";
            string result = "";
            //string forreplacement = "";

            while (inputtext.IndexOf("<upcase>") != -1)
            {
                firstTag = inputtext.IndexOf("<upcase>");
                secondTag = inputtext.IndexOf("</upcase>");
                betweentags = inputtext.Substring(firstTag+8, secondTag - firstTag-8);
                //forreplacement = "<upcase>" + betweentags + "</upcase>";
                //replacement = forreplacement.ToUpper();
                inputtext.Remove(0, firstTag + 8);
                inputtext.Substring(inputtext.IndexOf("</upcase>"));
                //inputtext.Remove(inputtext.IndexOf("</upcase>", secondTag - firstTag -1);
                result = inputtext.Insert(firstTag, betweentags.ToUpper());
                
                inputtext = result;
            }

            Console.WriteLine(result);
           

        }
    }
}
