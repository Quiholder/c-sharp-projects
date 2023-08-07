using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            method2 obj = new method2();
            Console.WriteLine("Please enter a number...");
            int number = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Please enter another number...");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj.Addition(number + number2));

            Console.ReadLine();
        }
    }
}
