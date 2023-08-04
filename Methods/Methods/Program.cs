using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine("Please enter a number...");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(obj.Addition(number));
            Console.WriteLine(obj.Subtraction(number));
            Console.WriteLine(obj.Multiply(number));
            Console.ReadLine();
        }
    }
}
