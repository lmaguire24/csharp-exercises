﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("What word should I search for?");
            string theWord = Console.ReadLine();
            //int first = alice.IndexOf(theWord);
            //if first > (0);
            int answer = alice.IndexOf(theWord, System.StringComparison.CurrentCultureIgnoreCase);
            if (answer >= 1);
            Console.WriteLine("Found it!");
            Console.ReadLine();
        }
    }
}
