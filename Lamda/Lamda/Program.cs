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

            List<string> empList = new List<string>() {"Joe", "Mary", "Lewis","Nikki", "Harry", "Sally", "Joe","Jen", "Danielle","Britney"};
            Employee employee = new Employee();
            string count = employee.FirstName.Count(x => x.FirstName == employee.FirstName);//lamba expression
            int sum = IdList.Where(x => x > 5);
            Console.WriteLine(Where);
            foreach (Employee employee in employee.FirstName)
            {
                if (employee.FirstName == "Joe")
                {
                    new List();
                }
                Console.WriteLine(new List);
            }

        }
    }
}
