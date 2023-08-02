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
                names [i] += userName;
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
            //Assignment 2: to fix this infinite loop at i++ at end of names.Length.
            //for (int i = 0; i < names.Length;)
            //{
            //    Console.WriteLine(names[i]);

            //}
            List<string> computers = new List<string>() { "apple", "dell", "hp", "toshiba", "ibm" };
            Console.WriteLine("which computer brand would you prefer?");
            string userInput = Console.ReadLine();

            for (int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine(computers.Contains(userInput)};
        }
    }
        }
    }


