using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of Blackjack right now", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new BlackjackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();

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

////int count = deck.Cards.Count(x => x.Face == Face.Ace);

////List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
//int sum = numberList.Sum();
//Console.WriteLine(sum);

//Deck deck = new Deck();

//deck.Shuffle(3);

//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}
//Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();



