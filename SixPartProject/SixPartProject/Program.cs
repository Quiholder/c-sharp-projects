using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment  1
            string[] names = { "Quiana", "Destiny", "Alicia", "Brandon", "John" };
            Console.WriteLine("What is your last name?");
            string userName = Console.ReadLine();

            //Assignment1 & 3:comparison operator < is used  to determine whether to continue iterating the loop.
            for (int i = 0; i < names.Length; i++)
            {
                names[i] += userName;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            //Assignment 3: comparison operator <= is used. 
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            //Assignment 2: to fix this infinite loop add i++ at end of names.Length.
            //for (int i = 0; i < names.Length;)
            //{
            //Console.WriteLine(names[i]);

            //}
            //Assignment 4 
            List<string> computers = new List<string>() { "apple", "dell", "hp", "toshiba", "ibm" };
            Console.WriteLine("which computer brand would you prefer?");
            string userInput = Console.ReadLine();
            
            
             for (int i = 0; i < computers.Count; i++)
             {
                    if (userInput == computers[i])
                    {
                        Console.WriteLine(userInput + " is found at index " + i);//program closes after this line.
                        
                    }
                    else if (!computers.Contains(userInput))
                    {
                        Console.WriteLine("element not found in the given list");
                    }
                    //Console.ReadLine();
             }
            
            //Assignment 5
            List<string> computers2 = new List<string>() { "apple", "dell", "hp", "dell", "toshiba", "ibm" };
                Console.WriteLine("which computer brand would you prefer?");
                string userInput2 = Console.ReadLine();

              for (int q = 0; q < computers2.Count; q++)
              {
                    if (userInput2 == computers2[q])
                    {
                        Console.WriteLine(userInput2 + " is found at index " +  q);//break removed and progam works.
                    }
                    else if (!computers2.Contains(userInput2))
                    {
                        Console.WriteLine("element not found in the given list");
                    }
                    //Console.ReadLine();
              }
             //Assignment Part 6
             List<string> computers3 = new List<string>() { "apple", "dell", "hp", "apple", "toshiba", "ibm" };
             List<string> dupList = new List<string>();
             foreach (string comp in computers3)
             {
                    if (dupList.Contains(comp))
                    {
                        Console.WriteLine(comp +  " is a duplicate. ");
                    }
                    else
                    {
                        Console.WriteLine(comp +  " is unique.");
                        dupList.Add(comp);
                    }
             }
        Console.ReadLine();
        }
    }
}
    

           
    



