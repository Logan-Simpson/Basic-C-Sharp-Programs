﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 0;
            while (I < 10) 
            {
                Console.WriteLine(I);
                I++;
            }
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
            Console.ReadLine();
        }
    }
}
