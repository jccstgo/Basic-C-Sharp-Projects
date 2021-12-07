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

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jose";
            game += player;
            game -= player;


            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

       

    }
}
