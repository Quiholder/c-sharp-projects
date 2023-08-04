using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy1 = new Puppy("Siberian Husky", 2015, 5);
            Puppy puppy2 = new Puppy("Golden Retriever", 2020, 10);
            Puppy puppy3 = new Puppy("Pit Bull", 2023, 6);

            Console.WriteLine(puppy1.breed + " was born " + puppy1.birthyear + " in a litter of " + puppy1.litter);
            Console.ReadLine();

            Console.WriteLine(puppy3.birthyear - puppy1.birthyear);
            Console.ReadLine();
            
        }
    }
}
