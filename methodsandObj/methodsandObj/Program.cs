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
            Person person = new Person();
            Employee employee = new Employee();
            employee.FirstName = ("sample");
            employee.LastName = ("student");
            Console.WriteLine("name:");
            string SayName = Console.ReadLine();
        }
    }
}
