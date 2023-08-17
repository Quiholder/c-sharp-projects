using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrCallChain
{
    class Class1
    {
        //Chain two constructors together.
        public Class1(string name) : this (name, 100)
        {
        }
        public Class1(string name, int newBalance)
        {
            Money = newBalance;
            Name = name;
        }
        //Name property declaration
        public string Name { get; set; }
        public int Money { get; set; }
    }
}
