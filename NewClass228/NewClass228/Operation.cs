using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClass228
{
    class Operation
    {
        public void Add(out int i, out int x)
        {
            int num1 = 20;
            i = num1 + 40;
            int num2 = 47;
            x = num2;
            Console.WriteLine(x);
        }
    }
}
