using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            byte centuries = byte.Parse(Console.ReadLine());
            //kakvato e promenlivata takova sledva da e i parsvaneto

            //ushort years = centuries * 100;
            //100 по дефолт е int. i ne moje da go umnojim s byte i da go prisvoim na ushort
            //za tova go kastvame kym ushort

            ushort years = (ushort)(centuries * 100);

            uint days = (uint)(years * 365.2422);

            uint hours = (uint)(days * 24);

            BigInteger minutes = (BigInteger)(hours * 60);

            BigInteger seconds = minutes * 60;

            BigInteger milliseconds = seconds * 1000;

            BigInteger microseconds = milliseconds * 1000;

            BigInteger nanoseconds = microseconds * 1000;


            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);

        }
    }
}
