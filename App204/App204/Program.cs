using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App204
{
    class Program
    {
        static void Main()
        {
            //part one
            string[] instruments = { "Piano", "Guitar", "Cello", "Violin", "Bass" };
            Console.WriteLine("Enter some text.");
            string text = Console.ReadLine();
            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i] = instruments[i] + text;
            }
            for (int i = 0; i < instruments.Length; i++)
            {
                Console.WriteLine(instruments[i]);
            }

            ////part two, infinite loop
            //for (int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            Console.ReadLine();
            //part two, infinite loop fixed
            for (int a = 0; a < 25; a++)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            //part three
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            //part three
            for (int y = 0; y <= 10; y++)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();

            //part four
            List<string> instruments2 = new List<string> { "Trumpet", "Flute", "Guitar", "Piano", "Violin" };
            Console.WriteLine("Enter an instrument name.");
            string input = Console.ReadLine();
            bool found = false;
            for (int y = 0; y < instruments2.Count; y++)
            {
                if (instruments2[y] == input)
                {
                    Console.WriteLine("The index is " + y);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("That was not in the list.");
            }
                Console.ReadLine();
                
            

            //part five
            List<string> cars = new List<string> { "Ford", "Dodge", "Chevrolet", "Honda", "Ford" };
            Console.WriteLine("Enter the name of a car brand. ");
            string inputCar = Console.ReadLine();
            found = false;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i] == inputCar)
                {
                    Console.WriteLine("Match found at index " + i);
                    found = true;
                }
                
            }
            if (!found)
            {
                Console.WriteLine("That car brand is not in the list.");
            }
            
            

            //part six

            List<string> cars2 = new List<string> { "Truck", "Sedan", "Coupe", "Van", "SUV", "Truck" };
            List<string> carsCopy = new List<string>();
            foreach (var item in cars2)
            {
                if (!carsCopy.Contains (item))
                {
                    carsCopy.Add(item);
                    Console.WriteLine("The item " + item + " has not appeared before in the list.");
                 }
                else
                {
                    Console.WriteLine("The item " + item + " has already been seen in the list.");
                }
             }
             Console.ReadLine();

           


        }
    }
}
