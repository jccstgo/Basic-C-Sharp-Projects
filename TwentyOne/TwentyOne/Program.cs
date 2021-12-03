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
            Deck deck = new Deck();
            int shuffleTimes = 0;
            deck = Shuffle(deck, out shuffleTimes,3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " +card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine(shuffleTimes);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int shuffleTimes, int times = 1)
        {
            shuffleTimes = 0;
            for (int i = 0; i < times; i++)
            {
                shuffleTimes++;
                List<Card> tempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {                    
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    tempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = tempList;
            }
            
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times) 
        //{
        //    for (int i = 0; i<times; i++) 
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
