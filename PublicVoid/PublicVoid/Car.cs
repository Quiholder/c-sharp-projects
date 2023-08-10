using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVoid
{
    class Car
    {
        public void Divide( int num)
        {
            Console.WriteLine(num / 2);
        }
        public int Divide(int num, out int num2)
        {
            num2 = num / 4;
            return num / 2;
        }
    }
}
//You can overload a method by specifying a different number of parameters
//You can specify an output parameter by using
