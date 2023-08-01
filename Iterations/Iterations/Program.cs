using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 99, 98, 87, 34, 88, 70, 92, 90 };

            ////first condition is the starting value int i = 0; next condition how long are you going to do the for loop?as long as i
            //// less than testacores.length and length is a property of an array.after for loop add 1 to i.
            //for (int i = 0; i < testScores.Length; i++) 
            //{

            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("passing test score is: " + testScores[i]);//console.writeline(testScores[i]); to show everything in the array.
            //    }
            //}
            //Console.ReadLine();
            //}
            //    }
            //}
            List<int> testScores = new List<int>();
            testScores.Add(99);
            testScores.Add(95);
            testScores.Add(80);
            testScores.Add(72);
            testScores.Add(75);

            //testscores is the list and score is item in list.this will go thru each item and do something with it
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("passing testscore! " + score);
                }
            }
            Console.ReadLine();

            List <string> names = new List<string>() { "quiana", "shayla", "jaden", "jehiel", "josiah" };
            foreach (string name in names)
            {
                if(name == "quiana") //to print out all names in lis remove this if line 
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();

            List<int> testScores1 = new List<int>() { 98, 99, 56, 89, 90 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);//this adds to passingscores list 
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
       

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
   




