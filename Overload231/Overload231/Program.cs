using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload231
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            int result;
            result = math.Divide();
        }
    }
}
