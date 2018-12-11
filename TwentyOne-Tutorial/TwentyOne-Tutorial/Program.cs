using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
                                                     //deck = Shuffle(deck); COMMENTING OUT NEW MTHOD OF SHUFFLE PARTICULAR NUMBER OF TIMES
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);
                                                    //deck.Cards = new List<Card>(); //REMOVING TO CREAT CONSTRUCTOR

                                                    //Card cardOne = new Card();
                                                    //cardOne.Face = "Queen";
                                                    //cardOne.Suit = "Spades";

                                                    //deck.Cards.Add(cardOne);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled {0}", timesShuffled);
                                                    //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit); //USED WITH PREVIOUS EXAMPLE
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }

                                                    //public static Deck Shuffle(Deck deck, int times)
                                                    //{
                                                    //    for (int i = 0; i < times; i++)
                                                    //    {
                                                    //        deck = Shuffle(deck);
                                                    //    }
                                                    //    return deck;
                                                    //}
    }
}
