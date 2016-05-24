using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n ; i++)
            {
                if (IsPalindrome(i) && IsDivBy7(i) && HasEven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int n)
        {
            string str = n.ToString();

            return str.SequenceEqual(str.Reverse());
            
        }

        static bool IsDivBy7(int n)
        {
            int sumOfDigits = 0;
            int digits = n;
            while (digits > 0)
            {
                sumOfDigits += digits % 10;
                digits = digits / 10;
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool HasEven(int n)
        {
            int div;
            int digits = n;
            bool flag = false;

            while (digits > 0)
            {

                div = digits % 10;
                if (div % 2 == 0)
                {
                    flag = true;
                    return flag;

                }
                digits = digits / 10;
            }

            return flag;
        }
    }
}
