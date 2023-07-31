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
            }
            Console.ReadLine();
            

            Console.WriteLine("What is the package width?");
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package height?");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package length?");
            int packLength = Convert.ToInt32(Console.ReadLine());

            string totalDimension = packWidth + packHeight + packLength > 50 ? "package too heavy to ship." : "your package can be shipped!";
            Console.WriteLine(totalDimension);
            Console.ReadLine();

            int quote = packHeight * packWidth * packLength * packWeight / 100;
            Console.WriteLine("your estimated total to ship this package is $ " + quote +  " Thank you");
            Console.ReadLine();


        }
    }
}
