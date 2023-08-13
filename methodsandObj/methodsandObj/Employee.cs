using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsandObj
{
    public class Employee : Person, IQuittable
    {
        //public override void SayName();
        //{   
        //    Console.WriteLine("Name: " + FirstName + " " + LastName);
        //}
    

        public void Quit()
        {
            Console.WriteLine("i quit");
        }
    }
}
    

    

    









