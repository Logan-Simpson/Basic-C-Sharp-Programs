using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }
        }
        Console.ReadLine();

        string[] names = { "Logan", "Jake", "Danielle", "Adam" };

        for (int j = 0; j < names.Length; j++)
        
            {
                Console.WriteLine(names[j]);
            }
        Console.ReadLine();

        List<int> testScore = new List<int>();
        testScore.Add(98);
        testScore.Add(99);
        testScore.Add(81);
        testScore.Add(72);
        testScore.Add(70);

        foreach (int score in testScore)
        {
            if (score > 85)
            {
                Console.WriteLine("Passing test score:" + score);
            }
        }
        Console.ReadLine();

        List<string> names = new List<string>() { "Logan", "Jake", "Danielle", "Adam" };

        foreach (string name in names)
        {
                Console.WriteLine(name);
        }
        Console.ReadLine();

        List<int> tests = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScore = new List<int>();

        foreach (int score in tests)
        {
            if (score > 85)
            {
                passingScore.Add(score);
            }
        }
        Console.WriteLine(passingScore.Count);
        Console.ReadLine();
        }
    }

