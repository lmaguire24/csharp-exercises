using System;
using System.Collections.Generic;

namespace ListsAndStrings
{
    class Program
    {
        static void Main()
        {
            List<string> words = new List<string>();
            words.Add("one");
            words.Add("fiver");
            words.Add("fours");
            words.Add("hour");

            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);

                }
            }
            {
                Console.ReadLine();

            }



        }
    }
}