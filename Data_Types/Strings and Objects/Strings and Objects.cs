﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            string thirdWord = firstWord + " " + secondWord;

            object sentence = thirdWord;
            
            string sentence_string = sentence.ToString();

            Console.WriteLine(sentence_string);
            
        }
    }
}
