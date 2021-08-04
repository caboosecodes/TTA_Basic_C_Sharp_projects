using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // To INHERIT from another class put a semicolon and the name of the calss to inherit from
    // a class can only inherit from a single class
    public class TwentyOneGame : Game, IWalkAway
    {
        // property
        public TwentyOneDealer Dealer { get; set; }

        // in order to implment the inherited abstract method you have to use override keyword
        public override void Play()
        {
            // instantiate Dealer object as new TwentyOneDealer object
            Dealer = new TwentyOneDealer();
            // reset the players
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            // if a new deck wasn't created, then after one round the deck would be incomplete
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet");

            foreach (Player player in Players) 
            {
                // user would enter their bet
                int bet = Convert.ToInt32(Console.ReadLine());
                // calling on the Player Bet method
                bool successfullyBet = player.Bet(bet);
                // if successfullyBet is flase
                if (!successfullyBet)
                {
                    // because this is in a void method, it does not return anything. It ends the method
                    return;
                }
                // If the the bet was susccesful 
                // creates the dictionary entry from Game Property
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    // checking for blackjack
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            // 
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            // remember we subtract the bet from the balance so the bet plus the winnings need to be added back
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            // once a player hits blackjack that round is over
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }

                    }
                }
            }
            // ask the player if they want to hit or stay
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
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
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
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
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting... ");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                // looping through each key value pair (dictionary)
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    // finding the player in the Players List that matches the Key Value pair where the names are equal
                    // Where() produces a list and First() grabs the player
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                // boolean with 3 possibles
                //turns the bool into a nullable datatype
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! no one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }

        public override void ListPlayers()
        {
            // added to the method
            Console.WriteLine("21 players");
            // automatically put in
            // equivalent to the virtual method in Game
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
