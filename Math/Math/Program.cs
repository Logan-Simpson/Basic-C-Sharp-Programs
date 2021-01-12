using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int numb = Convert.ToInt32(Console.ReadLine());
            int product = numb * 50;
            Console.WriteLine("The number you entered, times 50 is " + product);
            Console.ReadLine();

            Console.WriteLine("Enter a new number.");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = numb2 + 25;
            Console.WriteLine("The new number, added to 25 is " + sum1);
            Console.ReadLine();

            Console.WriteLine("Enter another number.");
            int numb3 = Convert.ToInt32(Console.ReadLine());
            double quotient = numb3 / 12.5;
            Console.WriteLine("This number, divided by 12.5 is " + quotient);
            Console.ReadLine();

            Console.WriteLine("Enter a new number to check if it is greater than 50.");
            int numb4 = Convert.ToInt32(Console.ReadLine());
            bool TorF = numb4 > 50;
            Console.WriteLine(TorF);
            Console.ReadLine();

            Console.WriteLine("Let's see if this number divided by 7 has a remainder.");
            int numb5 = Convert.ToInt32(Console.ReadLine());
            int remainder = numb5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
