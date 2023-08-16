using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //initiate two employee objoects and assign values to their properties
            Employee employee = new Employee();
           
            employee.ID = 1;
            employee.FirstName = "Carol";
            employee.LastName = "Smith";

            Employee employee2 = new Employee();
            employee.ID = 2;
            employee.FirstName = "Sam";
            employee.LastName = "Smith";

            //compare two employee objects using newly overloaded operators
            Console.WriteLine(employee == employee2);
            Console.WriteLine(employee != employee2);

            Console.ReadLine();
        }
    }
}
