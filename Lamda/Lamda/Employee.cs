using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Employee
    {
        ///list with properties firstname,lastname and id 
        public List<string> Persons { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }
    }
}
