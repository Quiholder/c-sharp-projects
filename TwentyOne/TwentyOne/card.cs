using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card //design or model of an object
    {
        public struct Card
        {
            public Suit Suit { get; set; }//card class has property of data type string called suit can get or set the property public mean accessible to other parts of program
            public Face Face { get; set; }
            public override string ToString()
            {
                return string.Format("{0} OF {1}", Face, Suit);
            }
         }
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
        public enum Face
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten
        }
    }
}
