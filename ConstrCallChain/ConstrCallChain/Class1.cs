using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrCallChain
{
    class Class1
    {
        public Class1(string name) : this (name, 100)
        {
        }
        public Class1(string name, int newBalance)
        {
            Quarter = new List<Card>();
            Money = newBalance;
            Name = name;
        }
        public List<Card> Quarter { get; set; }
        public int Money { get; set; }
    }
}
