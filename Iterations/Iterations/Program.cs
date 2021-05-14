using System;
using System.Collections.Generic;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing Test Score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Joe", "Mama", "Deepak" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(80);
            //testScores.Add(72);
            //testScores.Add(70);
            //testScores.Add(2);

            //foreach(int score in testScores)
            //{
            //    if(score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}

            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Joe", "Mama", "Deepak" };

            //foreach (string name in names)
            //{
            //    //if (name == "Jesse")
            //    //{
            //        Console.WriteLine(name);

            //    //}
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int> { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
