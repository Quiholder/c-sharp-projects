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
            int person1hrsWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your hours worked: " + person1hrsWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("hourly rate");
            int person2Hrly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your hourly rate: " + person2Hrly);
            Console.ReadLine();
            
            Console.WriteLine("hours worked");
            int person2HrWrk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your hours worked: " + person2HrWrk);
            Console.ReadLine();
           
            Console.WriteLine("annual salary person1");
            int annualSalary1 = person1hrly * person1hrsWorked * 52;
            Console.WriteLine("your annual salary is:" + annualSalary1);
            Console.ReadLine();

            Console.WriteLine("annual salary person2");
            int annualSalary2 = person2Hrly * person2HrWrk * 52;
            Console.WriteLine("your annual salary is:" + annualSalary2);
            Console.ReadLine();

            Console.WriteLine("Does person1 make more than person2?");
            bool trueorFalse = annualSalary1 > annualSalary2;
            Console.WriteLine(trueorFalse.ToString());
            Console.ReadLine();





        }
    }
}
