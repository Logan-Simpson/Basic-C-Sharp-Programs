using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class227
{
    class Program
    {
        static void Main(string[] args)
        {
            arithmetic math1 = new arithmetic();
            Console.WriteLine("Please enter a number.");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you want, enter a second number.");
            string x = Console.ReadLine();
            int result;
            if (x == "")
            {
                result = math1.AddTwo(i);
            }
            else
            {
                int y = Convert.ToInt32(x);
                result = math1.AddTwo(i, y);
            }
            Console.WriteLine(result);
            Console.ReadLine();
            
            
        }
    }
}
