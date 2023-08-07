using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsandObj
{
    public class Person
    {
        public List<string> Persons { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void SayName()
        {
             Console.WriteLine("Name:[name]");
        }
       
        
    }
}

