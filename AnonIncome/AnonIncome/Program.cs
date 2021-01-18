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
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine();
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("20");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("31,200");
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine("41,600");
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = false;
            Console.WriteLine(moreMoney);
            Console.ReadLine();
        }
    }
}
