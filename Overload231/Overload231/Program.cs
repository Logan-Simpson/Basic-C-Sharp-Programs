﻿using System;
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
            int num = Convert.ToInt32(Console.ReadLine());
            math.Divide(num);
            Console.ReadLine();

            Math load = new Math();
            int x = 5;
            int y = 7;
            load.OutPut(out x, out y);
            return;
           
        }
    }
}
