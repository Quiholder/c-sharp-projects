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
            //Assignment Part 1
            string[] names =  { "Quiana", "Destiny", "Alicia", "Brandon", "John" };
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                names.Append(userName);
            }
           

            for (int i = 0; i <names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();


        }
    }
}
