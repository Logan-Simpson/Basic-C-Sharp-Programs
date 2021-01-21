using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
        try
        {
        List<int> Numbers = new List<int>() { 12, 4, 8, 60, 5 };
        Console.WriteLine(Numbers[0]);
        Console.WriteLine(Numbers[1]);
        Console.WriteLine(Numbers[2]);
        Console.WriteLine(Numbers[3]);
        Console.WriteLine(Numbers[4]);

        Console.WriteLine("Pick a number to divide by each number in the list.");
        int numberOne = Convert.ToInt32(Console.ReadLine());
        foreach (var i in Numbers )
        {
            var result = i / numberOne;
                Console.WriteLine(result);
        }
            Console.ReadLine();

        List<int> NumResult = new List<int>();
        foreach (var item in NumResult)
        {
            NumResult.Add(item / numberOne);
            Console.WriteLine(NumResult);
        }
        
        Console.ReadLine();
        //Console.WriteLine(number + " equals " + numberThree);
        //Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    
        }
    }


