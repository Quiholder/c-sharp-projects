using System;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Quiana";
            string name2 = "Ariel";
            string name3 = "Jenna";

            Console.WriteLine(name + name2  +  name3  +  "are all in the same class");
            Console.ReadLine();

            name = name.ToUpper();
            Console.WriteLine(name);
        }
    }
}
