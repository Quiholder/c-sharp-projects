using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)

        {
            
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);
            Console.ReadLine();
            Console.WriteLine("Please enter a number...");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("in" + userNumber + "hours it will be" + currentDateTime + userNumber);
            Console.ReadLine();
        }
        
    }
}
