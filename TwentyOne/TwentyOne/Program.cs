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

            //TwentyOneGame twentyOneGame = new TwentyOneGame();
            //twentyOneGame.Players = new List<string>() { "Jose", "Carlos", "Cruz"};
            //twentyOneGame.ListPlayers();

            //TwentyOneGame t = new TwentyOneGame();
            //t.Players = new List<string>() {"Jose", "Carlos", "Cruz" };
            //t.ListPlayers();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jose";
            //game += player;
            //game -= player;
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Nine;
            //card2.Face = Face.Queen;

            //Console.WriteLine(card1.Face);


            Deck deck = new Deck();
            //int count = deck.Cards.Count(x => x.Face == Face.Queen);

            List<Card> newListCards = deck.Cards.Where(x => x.Face == Face.Seven).ToList();

            foreach (Card card in newListCards)
            {
                Console.WriteLine(card.Face);
            }
            

            //deck.Shuffle();

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

       

    }
}
