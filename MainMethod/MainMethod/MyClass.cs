using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MyClass
    {
        public int Subtraction(int num)
        {
            return num - 5;
        }
        public int Subtraction(decimal num)
        {
            return Convert.ToInt32(num) - 10;
        }
        public int Subtraction(string num)
        {
            return Convert.ToInt32(num) - 2; ;
        }
    }
}
