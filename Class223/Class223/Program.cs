using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class223
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Math math1 = new Math();
            Console.WriteLine("Please enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            math1.Add(x);
            math1.Subtract(x);
            math1.Multiply(x);

            Console.WriteLine("Your number + 20 is " + math1.Add(x));
            Console.WriteLine("Your number minus 50 is " + math1.Subtract(x));
            Console.WriteLine("Your number times 37 is " + math1.Multiply(x));
            Console.ReadLine();

            
        }
    }
}
