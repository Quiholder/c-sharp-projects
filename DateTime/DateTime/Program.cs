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

            //Asks the user for a number and add user input to current time 
            Console.WriteLine("Please enter a number...");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            DateTime d1 = new DateTime(2023, 08, 16, 9, 0, 10);
            DateTime d2 = d1.AddHours(userNumber);
            Console.WriteLine("initial DateTime= {0:dd} {0:y}, {0:t}", d1);
            Console.WriteLine("new DateTime (after adding hrs) = {0:dd} {0:y}, {0:t}", d2);
            Console.ReadLine();
        }
        
    }
}
