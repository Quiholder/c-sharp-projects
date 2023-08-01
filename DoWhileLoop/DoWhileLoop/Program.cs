using System;


namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 5;
            do
            {
                switch (number)
                {
                    case 25:
                        Console.WriteLine("you guessed 25! sorry, try again!");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("you guessed 12! sorry, try again!");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    // this result is showing up on console twice when ran not sure why
                    case 5:
                        Console.WriteLine("you guessed 5! That is correct!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You haven't guessed correctly yet. Keep trying!");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            //! same as isGuessed = false
            while (!isGuessed);
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
                break;
            }
            Console.ReadLine();
        }
    }
}

                