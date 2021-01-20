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
            foreach (string i in instruments)
            {
                Console.WriteLine(i + text);
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
            foreach (string instrument in instruments2)
            {
                if (instruments2.Contains(input))
                {
                    Console.WriteLine("This list contains " + input);
                }
                else
                {
                    Console.WriteLine("That instrument is not on the list.");
                }
                Console.ReadLine();
                break;
            }

            //part five
            List<string> cars = new List<string> { "Ford", "Dodge", "Chevrolet", "Honda", "Ford" };
            Console.WriteLine("Enter the name of a car brand. ");
            string inputCar = Console.ReadLine();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i] == inputCar)
                {
                    Console.WriteLine("Match found at index " + i);
                }
            }
            Console.ReadLine();

            //part six

            List<string> cars2 = new List<string> { "Truck", "Sedan", "Coupe", "Van", "SUV", "Truck" };
            List<string> carsCopy = new List<string>();
            foreach (var item in cars2)
            {
                foreach (var itemCopy in carsCopy)
                {
                    if (item == itemCopy)
                    {
                        Console.WriteLine("The item " + item + " has appeared before in the list.");
                    }
                }
                carsCopy.Add(item);
            }
            Console.ReadLine();

            //part two, infinite loop
            for (int a = 0; a < 50; a--)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            
        }
    }
}
