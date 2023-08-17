using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("what year were you born?");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Do not enter 0 or a negative number.");
                Console.ReadLine();
               

            }
        }
    }
}
