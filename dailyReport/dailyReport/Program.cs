using System;

namespace dailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
           
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("You course is: " + courseName);
            Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Do you need help with anything else? true or false");
            bool help = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you like to share?");
            string experience = Console.ReadLine();

            Console.WriteLine("Any other feedback, please be specific?");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That is great you studied for: " + studyHours + "hours");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day! This is the end of the program.");
            Console.ReadLine();
        }
    }
}
