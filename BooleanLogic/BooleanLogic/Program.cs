using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is: " + yourAge);
            Console.ReadLine();

            Console.WriteLine("have you ever had a dui? true or false");
            bool anyDui = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();
            

            Console.WriteLine("how many speeding tickets do you have?");
            int speedTicket = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            bool canGetIns = (yourAge > 15 && anyDui == false && speedTicket <= 3);
            Console.WriteLine("Are you qualified? " + canGetIns);
            Console.ReadLine();





        }
    }
}
