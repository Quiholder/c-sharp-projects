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
            obj.Divide(number);      //When you call the Divide() with one parameter it calls a void method which prints out the value.  So you can't call the method in
                                    // Console.Write(obj.Divide(number)).

            Console.ReadLine();

            // passing the reference to the number variable in Main to the class method. 
            int number1 = 0;
            obj.Divide(number, out number1); //when calling the Divide method with two parameters, the first parameter needs to be an integer and the second an out integer. 
            Console.ReadLine();

        }
    }
}
