using System;
using System.Collections.Generic;


namespace ArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            //unsure how to get user input to display on console.
            string[] fruits = new string []{"apple","mango","banana","papaya"};
            Console.WriteLine("please select an index?");
            Console.WriteLine(fruits);
            Console.ReadLine();

            int[] numbers = new int [] {45,700,125,7000,1200 };
            Console.WriteLine("please select an index?");
            Console.WriteLine(numbers);
            Console.ReadLine();

            List<string> intList = new List<string>();
            intList.Add("hello");
            intList.Add("there");
            intList.Remove("Quiana");
            Console.WriteLine(intList[0]);
            Console.ReadLine();




        }
    }
}
