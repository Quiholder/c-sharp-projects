﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public List<string> employees { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ID { get; set; }

        public static Employee operator= (Employee employee, ID id)
        {
            employee.ID.Equals(id);
            return employee;
        }
    }
}
