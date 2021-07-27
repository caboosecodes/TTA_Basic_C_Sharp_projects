using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
        //// the first condition will be the starting value
        //// until when will this loop be happening
        //// what do you want to do after the for loop is complete
        //for (int i = 0; i < testScores.Length; i++)
        //// what you want to do inside a for loop is inside the curly brackets
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}

        //Console.ReadLine();

        // new instance of a list object
        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        // score is just a variable name
        // score represents the item in the list
        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }
        //}
        //Console.ReadLine();


        // typically a name of lists is plural
        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}
        //Console.ReadLine();


        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        // you can leave a list empty unlike an array
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