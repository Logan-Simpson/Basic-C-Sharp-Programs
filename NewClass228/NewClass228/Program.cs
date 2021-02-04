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
            int i = 100;
            int x = 30;
            int num1 = 20;
            int num2 = 10;
            Operation.Add(i: num1, x:num2);
            Console.WriteLine("After method call,: {0}", i, x);
            Console.ReadLine();
        }
    }
}
