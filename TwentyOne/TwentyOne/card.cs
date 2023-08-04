using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card //design or model of an object
    {
        public Cards()
        {
            Suit = "Spades";//constructor: default values if none assigned
            Face = "Two";
        }

        public string Suit { get; set; }//card class has property of data type string called suit can get or set the property public mean accessible to other parts of program
        public string Face { get; set; }
    }
}
