using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find the MPG of your car. How many miles have you driven?");
            string milesDriven = Console.ReadLine();
            float miles = Convert.ToInt16(milesDriven);

            Console.WriteLine("Now tell me how many gallons you used:");
            string gallonsUsed = Console.ReadLine();
            float gallons = Convert.ToInt16(gallonsUsed);


            float MPG = miles / gallons;
            Console.WriteLine("You are getting " + MPG + " miles per gallon");
            Console.ReadLine();

        }
    }
}
