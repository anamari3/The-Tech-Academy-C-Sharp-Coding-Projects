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
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);
            //                                        //deck.Cards = new List<Card>(); //REMOVING TO CREATE CONSTRUCTOR

            //                                        //Card cardOne = new Card();
            //                                        //cardOne.Face = "Queen";
            //                                        //cardOne.Suit = "Spades";

            //                                        //deck.Cards.Add(cardOne);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }

                                                    //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
                                                    //{
                                                    //    timesShuffled = 0;
                                                    //    for (int i = 0; i < times; i++)
                                                    //    {
                                                    //        timesShuffled++;
                                                    //        List<Card> TempList = new List<Card>();
                                                    //        Random random = new Random();

                                                    //        while (deck.Cards.Count > 0)
                                                    //        {
                                                    //            int randomIndex = random.Next(0, deck.Cards.Count);
                                                    //            TempList.Add(deck.Cards[randomIndex]);
                                                    //            deck.Cards.RemoveAt(randomIndex);
                                                    //        }
                                                    //        deck.Cards = TempList;
                                                    //    }
                                                    //    return deck;
                                                    //}

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
