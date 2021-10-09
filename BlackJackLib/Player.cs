using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BlackJackLib
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> HandOfCards { get; set; }
        public int CardValue { get; set; } = 0;
        public System.Windows.Controls.Image myImage { get; set; }

        public Player() {
        }
        public Player(int cardValue, System.Windows.Controls.Image myimage) 
        {
            this.CardValue = cardValue;
            this.myImage = myimage;
        }

        public int UpdateValue ()
        {
            foreach (var card in this.HandOfCards)
                CardValue += card.Value;

            return this.CardValue;
        }

        public void UpdateImage(Card card)
        {
            myImage.Source = new BitmapImage(new Uri(card.FilePath));
        }

        public void Hit(Queue<Card> deck)
        {
            this.HandOfCards = new Queue<Card>();
            this.HandOfCards.Enqueue(deck.Dequeue());
            UpdateValue();
            UpdateImage(this.HandOfCards.Last());
            isBusted();
        }


        public bool isBusted()
        {

            if (this.CardValue > 10 && HandOfCards.Last().Value == 11)
            {
                HandOfCards.Last().ChangeValue();
                return false;
            }
            else if (this.CardValue <= 21)
                return false;
            else
                return true;
        }

    }
}
