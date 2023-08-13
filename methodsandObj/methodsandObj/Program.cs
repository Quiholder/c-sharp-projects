using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsandObj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            //Employee employee = new Employee();
            //employee.FirstName = ("sample");
            //employee.LastName = ("student");

            //Console.WriteLine("name:" + employee.FirstName + employee.LastName);
            //employee.SayName();
            //This demonstrates polymorphism by creating an employee object fo type IQuttable
            IQuittable employee1 = new Employee();
            employee1.Quit(); //call the Quit() method
            
            Console.ReadLine();
        }
    }
}
