using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            uint employNum = uint.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + sex);
            Console.WriteLine("Personal ID: " + ID);
            Console.WriteLine("Unique Employee number: " + employNum);

        }
    }
}
