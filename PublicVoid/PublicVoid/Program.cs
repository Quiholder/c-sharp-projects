using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            Console.WriteLine("Please enter a number...");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj.Divide(number));

            Console.ReadLine();

            // passing the reference to the number variable in Main to the class method. 
            int number = 0;
            obj.Divide(out number, out int num2);

        }
    }
}
