using System;


namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package Express. Please follow instruction below...");
            Console.ReadLine();

            Console.WriteLine("What is the package weight?");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Your package is too heavy to shipped via Package Express. Have a great day!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the package width?");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package height?");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package length?");
                int packLength = Convert.ToInt32(Console.ReadLine());

                int totalDimension = packWidth + packHeight + packLength;
                if (totalDimension > 50)
                {
                    Console.WriteLine("Package is too bigg to ship.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your package can be shipped!");
                    int quote = packHeight * packWidth * packLength * packWeight / 100;
                    Console.WriteLine("your estimated total to ship this package is $ " + quote + " Thank you");
                    Console.ReadLine();
                }
            }

        }
    }
}
