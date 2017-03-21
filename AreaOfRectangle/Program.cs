using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find the area of a rectangle");
            Console.WriteLine("What is the length?");
            string first = Console.ReadLine();
            double length = Convert.ToInt16(first);

            Console.WriteLine("What is the height?");
            string second = Console.ReadLine();
            double height = Convert.ToInt16(second);

            Console.WriteLine("The area of the rectangle is " + (length * height));
            Console.ReadLine();

        }
    }
}
