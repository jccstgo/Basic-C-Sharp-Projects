using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            //int[] testScores = {95,80,85,91,92,93,74,85,86 };

            //for (int i = 0; i < testScores.Length; i++) {
            //    if (testScores[i]>85) {
            //        Console.WriteLine("Passing test score: "  + testScores[i]);
            //    }

            //}
            //string[] names = {"Jose","Carlos", "Cruz", "Santiago"};
            //for (int j = 0; j < names.Length; j++) {
            //        Console.WriteLine(names[j]);               
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(70);
            //testScores.Add(72);

            //foreach (int score in testScores) 
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing: " + score);
            //    }
            //}

            //List<string> names = new List<string>() { "Jose", "Carlos", "Cruz", "Santiago" };

            //foreach (string name in names)
            //{
            //    //if (name == "Carlos")
            //    //{
            //        Console.WriteLine("The name is: " + name);
            //    //}
            //}

            List<int> testScores = new List<int>() { 98,99,74,12,74,23,99};
            List<int> passingScores = new List<int>();

           
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine("Passing: " + passingScores.Count);
            Console.WriteLine(passingScores);

            StringBuilder myString = new StringBuilder();
            

            Console.ReadLine();
        }
    }
}
