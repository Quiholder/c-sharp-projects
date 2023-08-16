using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        //create an employee class with id firstname ans lastname properties 
        public List<string> employees { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; set; }

        //overloaded == operator passing in two Employee objects
        public static bool operator== (Employee employee, Employee employee2)
        {
            //compares each Employee objects by compaing there IDS 
            return employee.ID == employee2.ID;
        }
        public static bool operator!= (Employee employee, Employee employee2) //overload !=
        {
            //Compare each Employee objects by comparing IDs.
            return employee.ID != employee2.ID;
        } 
        
    }
}
