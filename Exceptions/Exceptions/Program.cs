using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + "divded by" + numberTwo + "equals" + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("pls pick a number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("pls do not divide by 0.");
            }
            catch (Exception ex)// general exeption
            {
                Console.WriteLine(ex.Message);
            } 

           
            finally
            {
                Console.ReadLine();
            }
        }
    }
}//use exception to log errors to a database also helpful in debugging 
