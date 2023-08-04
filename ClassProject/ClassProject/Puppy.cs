using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    class Puppy
    {
        public string breed;
        public int birthyear;
        public int litter;

        public Puppy(string argBreed, int argBirthyear, int argLitter)
        {
            breed = argBreed;
            birthyear = argBirthyear;
            litter = argLitter;
        }
    }
}
