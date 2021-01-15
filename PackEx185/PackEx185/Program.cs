using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackEx185
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped.");
            }
            else
            {
                Console.WriteLine("Thank you.");
            }
            Console.WriteLine("Please enter package width.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package height.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter package length.");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width + height + length <= 50)
            {
                Console.WriteLine("Thank you.");
            }
            else
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
            }
            int product = height * width * length * weight;
            double quote = product / 100; Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your estimated total for shipping this package is:" + "$" + quote);
            Console.ReadLine();
            Console.WriteLine("Thank you!");
            Console.ReadLine();
           
        }
    }
}
