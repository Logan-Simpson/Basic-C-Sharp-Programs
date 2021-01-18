using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolLogic168
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter true or false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (age >= 15 && DUI == false && Tickets <= 3)
            {
                Console.WriteLine("You are qualified.");
            }
            else
            {
                Console.WriteLine("You are not qualified.");
            }
            Console.ReadLine();
        }
    }
}
