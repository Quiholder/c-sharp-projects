﻿using System;
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
            Employee employee = new Employee();
            ID id = new ID();
            employee.ID = "A1";
            employee.FirstName = "Carol";
            employee = employee == id;
        }
    }
}
