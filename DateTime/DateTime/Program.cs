using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDate
{
    class Program
    {
        static void Main(string[] args)

        {
            //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);
            Console.ReadLine();

            //Asks the user for a number.
            Console.WriteLine("Please enter a number...");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("in" + userNumber + "hours it will be" + currentDateTime + userNumber);
            Console.ReadLine();
        }
        
    }
}
