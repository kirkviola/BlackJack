using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class DeckMethods
    {

        public static Queue<Card> DeckAssembler()
        {
            Queue<Card> Deck = new Queue<Card>();
            Deck.Enqueue(new Card("2Clubs", 2));
            Deck.Enqueue(new Card("3Clubs", 3));
            Deck.Enqueue(new Card("4Clubs", 4));
            Deck.Enqueue(new Card("5Clubs", 5));
            Deck.Enqueue(new Card("6Clubs", 6));
            Deck.Enqueue(new Card("7Clubs", 7));
            Deck.Enqueue(new Card("8Clubs", 8));
            Deck.Enqueue(new Card("9Clubs", 9));
            Deck.Enqueue(new Card("10Clubs", 10));
            Deck.Enqueue(new Card("JackClubs", 10));
            Deck.Enqueue(new Card("QueenClubs", 10));
            Deck.Enqueue(new Card("KingClubs", 10));
            Deck.Enqueue(new Card("AceClubs", 11));
            Deck.Enqueue(new Card("2Diamonds", 2));
            Deck.Enqueue(new Card("3Diamonds", 3));
            Deck.Enqueue(new Card("4Diamonds", 4));
            Deck.Enqueue(new Card("5Diamonds", 5));
            Deck.Enqueue(new Card("6Diamonds", 6));
            Deck.Enqueue(new Card("7Diamonds", 7));
            Deck.Enqueue(new Card("8Diamonds", 8));
            Deck.Enqueue(new Card("9Diamonds", 9));
            Deck.Enqueue(new Card("10Diamonds", 10));
            Deck.Enqueue(new Card("JackDiamonds", 10));
            Deck.Enqueue(new Card("QueenDiamonds", 10));
            Deck.Enqueue(new Card("KingDiamonds", 10));
            Deck.Enqueue(new Card("AceDiamonds", 11));
            Deck.Enqueue(new Card("2Hearts", 2));
            Deck.Enqueue(new Card("3Hearts", 3));
            Deck.Enqueue(new Card("4Hearts", 4));
            Deck.Enqueue(new Card("5Hearts", 5));
            Deck.Enqueue(new Card("6Hearts", 6));
            Deck.Enqueue(new Card("7Hearts", 7));
            Deck.Enqueue(new Card("8Hearts", 8));
            Deck.Enqueue(new Card("9Hearts", 9));
            Deck.Enqueue(new Card("10Hearts", 10));
            Deck.Enqueue(new Card("JackHearts", 10));
            Deck.Enqueue(new Card("QueenHearts", 10));
            Deck.Enqueue(new Card("KingHearts", 10));
            Deck.Enqueue(new Card("AceHearts", 11));
            Deck.Enqueue(new Card("2Spades", 2));
            Deck.Enqueue(new Card("3Spades", 3));
            Deck.Enqueue(new Card("4Spades", 4));
            Deck.Enqueue(new Card("5Spades", 5));
            Deck.Enqueue(new Card("6Spades", 6));
            Deck.Enqueue(new Card("7Spades", 7));
            Deck.Enqueue(new Card("8Spades", 8));
            Deck.Enqueue(new Card("9Spades", 9));
            Deck.Enqueue(new Card("10Spades", 10));
            Deck.Enqueue(new Card("JackSpades", 10));
            Deck.Enqueue(new Card("QueenSpades", 10));
            Deck.Enqueue(new Card("KingSpades", 10));
            Deck.Enqueue(new Card("AceSpades", 11));
            return Deck;
        }


        public static Queue<Card> ShuffleDeck(Queue<Card> initDeck)
        {
            Queue<Card> ShuffledDeck = new Queue<Card>();
            Random rand = new Random(); var CardCount = initDeck.Count();


            while (CardCount > 0)
            {
                int movedcards = rand.Next(1, 4);
                if (movedcards > CardCount)
                {
                    movedcards = CardCount;
                }
                for (int i = 1; i <= movedcards; i++)
                {

                    ShuffledDeck.Enqueue(initDeck.Dequeue());
                }

                initDeck = new Queue<Card>(initDeck.Reverse());
                CardCount = initDeck.Count;
            }

            return ShuffledDeck;
        }
        // Three Shuffles --> use this method in the program body.
        public static Queue<Card> MultiShuffler(Queue<Card> initDeck)
        {
            Queue<Card> FirstShuffle = new Queue<Card>();
            Queue<Card> SecondShuffle = new Queue<Card>();
            Queue<Card> ThirdShuffle = new Queue<Card>();

            foreach (Card card in initDeck)
                FirstShuffle.Enqueue(card);

            SecondShuffle = ShuffleDeck(FirstShuffle);
            return ThirdShuffle = ShuffleDeck(SecondShuffle);
        }
    }
}
