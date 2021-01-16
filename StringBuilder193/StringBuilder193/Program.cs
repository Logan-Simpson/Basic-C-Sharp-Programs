using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder193
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Logan ";
            string lName = "Simpson";
            string mName = "Howard ";
            Console.WriteLine(fName + mName + lName);
            Console.ReadLine();
            string msg = "This is challenging but it is awesome!";
            Console.WriteLine(msg.ToUpper());
            Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Logan");
            sb.AppendLine("I am from St. George, Utah.");
            sb.AppendLine("Currently living in Portland, Oregon and enrolled in the C# bootcamp at The Tech Academy!");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
