using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime yearofBirth = new DateTime(1998, 5, 23, 8, 32, 45);
            DateTime yearofGraduation = new DateTime(2013, 8, 1, 18, 34, 22);
            TimeSpan AgeAtGraduation = yearofGraduation - yearofBirth;
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());//Assign their answer to variable name bank
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);//{0} placeholder for their name
            string answer = Console.ReadLine().ToLower();//case sensitive
            if (answer == "yes")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino.Bye fo now.");//if they say no this will run
            Console.ReadLine();
        }
    }
}
            
//            Deck deck = new Deck();
//            deck = Shuffle(deck);
//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face + " of " + card.Suit);
//            }
//            Console.WriteLine(deck.Cards.Count);
//            Console.ReadLine();
//            //deck.Card = new List<Card>();
//            //Card cardOne = new Card();//object of datatype card assigned to variable cardOne 
//            //cardOne.Face = "Queen"; //assigned the string queen to property face of object cardOne
//            //cardOne.Suit = "Spades";

//            //deck.Card.Add(cardOne);
//            //Console.WriteLine(deck.Cards[01].Face + " of " + deck.Cards[0].Suit);
//            //Console.ReadLine();
//        }
//        public static Deck Shuffle (Deck deck)
//        {
//            List<Card> TempList = new List<Card>();
//            Random random = new Random();

//            while (deck.Cards.Count > 0)
//            {
//                int randomIndex = random.Next(0, deck.Cards.Count);
//                TempList.Add(deck.Cards[randomIndex]);
//                deck.Cards.RemoveAt(randomIndex);
//            }
//            deck.Cards = TempList;
//            return deck;
//        }
//    }
//}
