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
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput > 0 && userInput < fruits.Length)
            {
                Console.WriteLine(fruits[userInput]);
            }
            else
            {
                Console.WriteLine("That index does not exist.");
            }
           

           

            int[] numbers = new int [] {45,700,125,7000,1200 };
            Console.WriteLine("please select an index?");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            if (userInput2 > 0 && userInput2 < numbers.Length)
            {
                Console.WriteLine(numbers[userInput2]);
            }
            else
            {
                Console.WriteLine("That index does not exist.");
            }


            List<string> intList = new List<string>();
            intList.Add("hello");
            intList.Add("there");
            intList.Add("Quiana");
            Console.WriteLine("please select an index?");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            if(userInput3 > 0 && userInput3 < 3)
            { 
                Console.WriteLine(intList[userInput3]);
            }
            else
            {
                Console.WriteLine("That index does not exist.");
            }
            Console.ReadLine();




        }
    }
}
