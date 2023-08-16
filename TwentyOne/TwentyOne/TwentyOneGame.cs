using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()//call the play method
        {
            Dealer = new TwentyOneDealer();//create new dealer and loop through players
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();//reset player hand
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();//reset dealer hand as well//new hand dont wan old cards to stack up 
            Dealer.Stay = false;
            Dealer.deck = new Deck();//new deck each time /refresh deck
            Dealer.deck.Shuffle();
            Console.WriteLine("Place your bet!");
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet) //if successfullybet is false
                {
                    return;
                }
                Bets[player] = bet; //add to dictionary player name and bet
            }
            for (int i = 0; i < 2; i++)//give everyone a card loop thru players is done twice
            {
                Console.WriteLine("dealing...");
                foreach (Player player in Player)
                {
                    Console.Write("{0}:", player.Name);//write to console but dont automatically press enter to next line
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] + 1.5));
                            Bets.Remove(player);
                            return;
                        }
                    }
                }
                Console.Write("Dealer:");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("dealer has blackjack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (player.Stay)
                {
                    Console.WriteLine("Your cards are:");
                    foreach (Card card in Player.Hand)
                    {
                        Console.Write("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nhit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted == TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! you lose your bet of {1}. your balance is now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("dealer is staying");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted");
                foreach (KeyValuePair<Player, int> entry in Bets)//loop thru each key value pair find the player that matches 
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);//this person won this amount
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;

                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerwon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("push noone wins");
                    player.Balance += Bets[player];
                }
                else if (playerwon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] + 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
           


        } 
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();

        }
        public void walkAway (Player player)
        {
            throw new NotImplementedException();
        }
    }
}
