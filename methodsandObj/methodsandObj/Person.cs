using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsandObj
{
    public abstract class Person
    {
    public List<string> Persons { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    //public abstract void SayName();
    }
}





//In your Person class, we can use what is called string interpolation to directly reference the FirstName and LastName properties in the SayName method,

//public void SayName()
//{
//    Console.WriteLine($"Name: {FirstName} {LastName}");
//}

//In your Employee class, the ID property just needs to be an integer rather than a list of integers,

//public int ID { get; set; }

//Lastly in your main method, we can simplify the object creation and method call as so,

//Employee employee = new Employee
//{
//    FirstName = "sample",
//    LastName = "student"
//};
//employee.SayName();
