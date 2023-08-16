using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the day of the week.");
            string userInput = Console.ReadLine();
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine("you choose" + day);

            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }
    }
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
}
      
           
        
        

             
   
