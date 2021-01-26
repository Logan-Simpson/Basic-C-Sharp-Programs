using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newClass226
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass math2 = new mathClass();
            Console.WriteLine("Please enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());

            int result1 = math2.Add(x);

            Console.WriteLine("Enter a new number.");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            int result2 = math2.Add(input2);

            Console.WriteLine("Enter another number.");
            string input3 = Console.ReadLine();
            int result3 = math2.Add(input3);

            Console.WriteLine("Your first number plus 20 is " + result1);
            Console.WriteLine("Your second number minus 50 is " + result2);
            Console.WriteLine("Your third number plus 5 is " + result3);
            Console.ReadLine();

        }
    }
}
