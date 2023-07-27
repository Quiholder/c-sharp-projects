using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Annoymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();

             Console.WriteLine("hourly rate");
            int person1hrly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your hourly rate: " + person1hrly);
            Console.WriteLine("hours worked");
            string person1hrsworked = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("hourly rate");
            int person2Hrly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hourly rate: " + person2Hrly);
            
           
            Console.WriteLine("hours worked");
            string person2HrsWorked = Console.ReadLine();
           
            Console.WriteLine("annual salary person1");
            int annualSalary1 = ("person1hrly * person1hrsworked * 52");

            






        }
    }
}
