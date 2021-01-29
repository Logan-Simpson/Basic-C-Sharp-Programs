using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClass228
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Operation operation = new Operation();
            int number = 100;
            int num2 = 30;
            Console.WriteLine(number);
            operation.Add(out number, out num2);
            Console.WriteLine("After method call,: {0}", number, num2);
            Console.ReadLine();
        }
    }
}
