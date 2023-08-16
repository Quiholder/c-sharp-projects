using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Player
    {
        public Player(string name, int beginingBalance)//take two parameters and assign value
        {
            Hand = new List<Card>(); //initialize hand property.taking a constructor at top that take 2 args then assign them to properties in a class.
            Balance = beginingBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Cards>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not hav enough to place a bet that size.");
                return false;// mean the bet did not work
            }
            else
            {
                Balance = Balance - amount;
                return true;
            }
        }
        public static Game operator + (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static operator - (Game game, Player player)
            game.Players.Remove(player);
            return.game;


        
    }
}
