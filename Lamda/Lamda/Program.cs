using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>()
            {
                new Employee(){Id = 1, FirstName = "Anthony", LastName = "Davis"},
                new Employee(){Id = 2, FirstName = "Russell", LastName = "Wilson"},
                new Employee(){Id = 3, FirstName = "Steph", LastName = "Curry"},
                new Employee(){Id = 4, FirstName = "Lebron", LastName = "James"},
                new Employee(){Id = 5, FirstName = "Michael", LastName = "Jordan"},
                new Employee(){Id = 6, FirstName = "Kevin", LastName = "Durant"},
                new Employee(){Id = 7, FirstName = "Shelly", LastName = "lee"},
                new Employee(){Id = 8, FirstName = "Mark", LastName = "Mack"},
                new Employee(){Id = 9, FirstName = "Alicia", LastName = "Keys"},
                new Employee(){Id = 10, FirstName = "David", LastName = "Smalls"}
            }               
            
            Employee employee = new Employee();
            string count = employee.FirstName.Count(x => x.Id == employee.FirstName);//lamba expression
            int sum = IdList.Where(x => x > 5);
            Console.WriteLine(Id);
            foreach (Employee employees in employee.FirstName)
            {
                if (employee.FirstName == "Steph")
                {
                    new List();
                }
                Console.WriteLine(new List);
            }

        }
    }
}
