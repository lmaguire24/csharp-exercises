using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    public class Program
    { Dictionary<char, int> letterCount = new Dictionary<char, int>();
    string test_str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus."
    {
        foreach (char c in test_str)
           {
            if (!letterCount.ContainsKey(c))
            charCount.Add(c,1);

            else if (charCount.ContainsKey(c))
                charCount[c]++;



        {
            Console.WriteLine(c);
        }
    }
}
}
