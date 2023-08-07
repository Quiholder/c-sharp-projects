using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine("Please enter a number...");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(obj.Addition(number));
            
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(obj.Subtraction(number1));
            Console.ReadLine();
            //not sure how to pass in a string that equates to a number dont think this is correct. 
            Console.WriteLine("Spell out a number");
            string number2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(obj.Multiply(number2));
            Console.ReadLine();

        }
    }
}
