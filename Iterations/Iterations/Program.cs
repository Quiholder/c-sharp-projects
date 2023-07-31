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
            int[] testScores = { 99, 98, 87, 34, 88, 70, 92, 90 };
            
            //first condition is the starting value int i = 0; next condition how long are you going to do the for loop?as long as i
            // less than testacores.length and length is a property of an array.after for loop add 1 to i.
            for (int i = 0; i < testScores.Length; i++) 
            {
                
                if (testScores[i] > 85)
                {
                    Console.WriteLine("passing test score is: " + testScores[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
