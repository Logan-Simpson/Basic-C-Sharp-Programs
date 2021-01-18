using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        string[] Array = new string[] { "Hello", "Welcome", "Enjoy" };
        Console.WriteLine("Enter a number from 0-2.");
        Console.ReadLine();
        int input = int.Parse(Console.ReadLine());
        if (input == 0)
        {
            Console.WriteLine(Array[0]);
        }
        else if (input == 1)
        {
            Console.WriteLine(Array[1]);
        }
        else if (input == 2)
        {
            Console.WriteLine(Array[2]);
        }
        else
        {
            Console.WriteLine("Please enter a number from 0-2.");
        }
        Console.ReadLine();
        
        int[] numArray = { 5, 2, 10, 200 };

        Console.WriteLine("Enter a number from 0-3.");
        Console.ReadLine();
        int num1 = int.Parse(Console.ReadLine());
        if (num1 == 0)
        {
            Console.WriteLine(numArray[0]);
        }
        else if (num1 == 1)
        {
            Console.WriteLine(numArray[1]);
        }
        else if (num1 == 2)
        {
            Console.WriteLine(numArray[2]);
        }
        else if (num1 == 3)
        {
            Console.WriteLine(numArray[3]);
        }
        else
        {
            Console.WriteLine("Please enter a number from 0-3.");
        }
        Console.ReadLine();

        List<string> strList = new List<string>()
        {
            "Hello",
            "Welcome",
            "Enjoy!",
        };



    }
    }

