using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1: What is your hourly rate?");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            int hours1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2: What is your hourly rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            int salary1 = rate1 * hours1 * 52;
            Console.WriteLine("Person 1 annual salary: " + salary1);
            Console.ReadLine();
            int salary2 = rate2 * hours2 * 52;
            Console.WriteLine("Person 2 annual salary: " + salary2);
            Console.ReadLine();
            Console.WriteLine("Does person 1 make more money than person 2?");
            if (salary1 > salary2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
