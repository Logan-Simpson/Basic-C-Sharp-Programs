﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp888
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + favoriteNumber);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.30202092;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;
            string myName = "Logan";

            int currentAge = 27;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
