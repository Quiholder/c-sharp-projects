using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Method3
    {
        public void Addition(int num1 = 9, int num2 = 5)
        {
            Console.WriteLine(num1 + 2 + "and" + num2);
        }
        
       
        
            
     

          

    }
}
//The = 9 and the = 5 are default parameter values (which aren't part of the assignment).  You could remove those if you wanted to and the assignment would still be a pass.
//public void Addition(int num1 = 9, int num2 = 5)