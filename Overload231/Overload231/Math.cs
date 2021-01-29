using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload231
{
    public class Math
    {
        public void Divide(int x)
        {
            int result = x / 2;
            Console.WriteLine(result);
        }
        public int OutPut(out int x, out int y)
        {
            x = 5 + 10;
            y = 12 + 17;
            return x + y;
        }
        public int OutPut(int x, int y)
        {
            x = 5 + 10;
            y = 12 + 17;
            return x * y;
        }
    }
}
