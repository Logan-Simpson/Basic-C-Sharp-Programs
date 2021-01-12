using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport140
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            Console.WriteLine("The Tech Academy.");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report.");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("You are on the " + Course + "Course");
            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are on page " + page);
            Console.WriteLine("Do you need help with anaything? Please answer True or False");
            bool Help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string Experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
