﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Factoriel
{
    class Factoriel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            
            }

            Console.WriteLine(factorial);

        }
    }
}
