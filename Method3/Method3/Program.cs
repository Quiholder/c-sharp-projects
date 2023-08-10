using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Method3 obj = new Method3();

            obj.Addition(8,7);//passing in numbers to a method 
            obj.Addition(num1:4, num2:5);//passing named parameters
            Console.ReadLine();

        }
    }
}
