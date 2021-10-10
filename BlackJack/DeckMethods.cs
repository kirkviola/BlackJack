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
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/2_of_clubs.png/", 2));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/3_of_clubs.png/", 3));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/4_of_clubs.png/", 4));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/5_of_clubs.png/", 5));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/6_of_clubs.png/", 6));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/7_of_clubs.png/", 7));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/8_of_clubs.png/", 8));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/9_of_clubs.png/", 9));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/10_of_clubs.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/jack_of_clubs.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/queen_of_clubs.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/king_of_clubs.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/ace_of_clubs.png/", 11));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/2_of_diamonds.png/", 2));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/3_of_diamonds.png/", 3));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/4_of_diamonds.png/", 4));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/5_of_diamonds.png/", 5));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/6_of_diamonds.png/", 6));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/7_of_diamonds.png/", 7));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/8_of_diamonds.png/", 8));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/9_of_diamonds.png/", 9));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/10_of_diamonds.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/jack_of_diamonds.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/queen_of_diamonds.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/king_of_diamonds.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/ace_of_diamonds.png/", 11));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/2_of_hearts.png/", 2));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/3_of_hearts.png/", 3));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/4_of_hearts.png/", 4));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/5_of_hearts.png/", 5));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/6_of_hearts.png/", 6));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/7_of_hearts.png/", 7));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/8_of_hearts.png/", 8));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/9_of_hearts.png/", 9));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/10_of_hearts.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/jack_of_hearts.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/queen_of_hearts.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/king_of_hearts.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/ace_of_hearts.png/", 11));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/2_of_spades.png/", 2));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/3_of_spades.png/", 3));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/4_of_spades.png/", 4));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/5_of_spades.png/", 5));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/6_of_spades.png/", 6));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/7_of_spades.png/", 7));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/8_of_spades.png/", 8));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/9_of_spades.png/", 9));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/10_of_spades.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/jack_of_spades.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/queen_of_spades.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/king_of_spades.png/", 10));
            Deck.Enqueue(new Card("/repos/BlackJack/BlackJack/Images/ace_of_spades.png/", 11));
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
