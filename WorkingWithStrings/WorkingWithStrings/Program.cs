using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyString = String.Format ("{0} = {1}", "First", "Second");

            Console.WriteLine(MyString);
            Console.ReadLine();
        }
    }
}