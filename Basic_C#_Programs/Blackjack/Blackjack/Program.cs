using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            int sum = numberList.Sum();
            Console.WriteLine(sum);

            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}

//BlackjackGame game = new BlackjackGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
//game.ListPlayers();
//game.Play();
//Console.ReadLine();

//BlackjackGame game = new BlackjackGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
//game.ListPlayers();

//Game game = new BlackjackGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Jesse";
//game += player;
//game -= player;

//Card card = new Card();
//card.Suit = Suit.Clubs;
//int underlyingValue = Convert.ToInt32(Suit.Diamonds);
//Console.WriteLine(underlyingValue);



