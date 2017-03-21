using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            string input = Console.ReadLine();
            double radius = Convert.ToInt32(input);
            if (radius <= 0)
            {
                Console.WriteLine("That is not valid");
            }
            else
            {
                var area = 3.14 * (radius * radius);
                Console.WriteLine("The area of your circle is " + area);
                Console.ReadLine();
            }
        }
    }
}
