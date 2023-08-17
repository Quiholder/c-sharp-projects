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
                new Employee(){Id = 6, FirstName = "Joe", LastName = "Durant"},
                new Employee(){Id = 7, FirstName = "Shelly", LastName = "lee"},
                new Employee(){Id = 8, FirstName = "Mark", LastName = "Mack"},
                new Employee(){Id = 9, FirstName = "Joe", LastName = "Keys"},
                new Employee(){Id = 10, FirstName = "David", LastName = "Smalls"}

            }

            //Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking
            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in empList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            // same action again, but this time with a lambda expression
            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> joeList2 = empList.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> joeList3 = empList.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}







