using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_Of_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            long input = long.Parse(Console.ReadLine());

            Console.WriteLine(LastDigit(input));
            
                         
        }

        static string LastDigit(long x)
        {
            string lastLetter = "";
            long lastDigit = (long)(Math.Abs((double)(x % 10)));
            switch (lastDigit)
            {
                case 0: lastLetter = "zero"; break;
                case 1: lastLetter = "one"; break;
                case 2: lastLetter = "two"; break;
                case 3: lastLetter = "three"; break;
                case 4: lastLetter = "four"; break;
                case 5: lastLetter = "five"; break;
                case 6: lastLetter = "six"; break;
                case 7: lastLetter = "seven"; break;
                case 8: lastLetter = "eight"; break;
                case 9: lastLetter = "nine"; break;
                default: lastLetter = "other"; break;
            }

            return lastLetter;

        }
        
    }
}
