using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BlackJackLib
{
    public class Player
    {
        public string Name { get; set; }
        public Card currentCard { get; set; }
        public int CardValue { get; set; } = 0;
        public System.Windows.Controls.Image myImage { get; set; }

        public Player() {}
        public Player(int cardValue, System.Windows.Controls.Image myimage) 
        {
            this.CardValue = cardValue;
            this.myImage = myimage;
        }

        public void UpdateImage(Card card, bool turn)
        {
            Uri fileUri = new Uri(card.FilePath, UriKind.Relative);
            
        }

        public void Hit(Queue<Card> deck, bool turn)
        {

            this.currentCard = deck.Dequeue();
            this.CardValue += currentCard.Value;
            UpdateImage(this.currentCard);
            isBusted();
        }


        public bool isBusted()
        {

            if (this.CardValue > 10 && this.currentCard.Value == 11)
            {
                this.currentCard.ChangeValue();
                return false;
            }
            else if (this.CardValue <= 21)
                return false;
            else
                return true;
        }

    }
}
