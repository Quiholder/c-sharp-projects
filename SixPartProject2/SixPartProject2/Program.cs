using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> computers = new List<string>() { "apple", "dell", "hp", "toshiba", "ibm" };
            Console.WriteLine("which computer brand would you prefer?");
            string userInput = Console.ReadLine();

            for (int i = 0; i < computers.Count; i++)
            {
                Console.WriteLine(userInput[3]);
            }
            Console.ReadLine();
        }
    }
}
