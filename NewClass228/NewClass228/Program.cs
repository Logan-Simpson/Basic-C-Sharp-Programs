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
            int x = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            operation.Add(i, x);
            Console.ReadLine();
        }
    }
}
