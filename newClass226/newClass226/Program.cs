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
            
            mathClass.Add(x);
            mathClass.Add(x);
            mathClass.Add(x);

            Console.WriteLine("Your number + 20 is " + mathClass.Add(x));
            Console.WriteLine("Your number minus 50 is " + mathClass.Add(x));
            Console.WriteLine("Your number times 37 is " + mathClass.Add(x));
            Console.ReadLine();

        }
    }
}
