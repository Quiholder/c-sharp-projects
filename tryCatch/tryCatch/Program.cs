using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){ 10, 40, 20, 30, 60 };
            try
            {
                Console.WriteLine("pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (var item in numbers)
                {
                    Console.WriteLine(item / numberOne);
                }
                //for (int i = 0; i < numbers.Count; i++)
                //{
                //    Console.WriteLine(numbers[i] / numberOne);
                //}
            }
            catch (FormatException ex)
            {
                Console.WriteLine("pls pick a number");
                
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
}
