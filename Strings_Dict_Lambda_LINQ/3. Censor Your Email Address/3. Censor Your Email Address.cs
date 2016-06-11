using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Censor_Your_Email_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputEmail = Console.ReadLine();
            string text = Console.ReadLine();

            string[] words = inputEmail.Split('@');

            string user = words[0];
            string domain = words[1];

            //Console.WriteLine(user);
            //Console.WriteLine(domain);

            string hiddenuser = new string('*', user.Length);

            string replacement = hiddenuser + "@" + domain;

            string result = text.Replace(inputEmail, replacement);

            Console.WriteLine(result);


        }
    }
}
