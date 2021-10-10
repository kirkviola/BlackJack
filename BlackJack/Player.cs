using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BlackJack
{
    public class Player
    {
        public string Name { get; set; }
        public Card currentCard { get; set; }
        public int CardValue { get; set; } = 0;
        public System.Windows.Controls.Image myImage { get; set; }
        public System.Windows.Controls.Label myScore { get; set; }

        public Player() {}
        public Player(int cardValue, System.Windows.Controls.Image myimage,
                        System.Windows.Controls.Label myscore) 
        {

            this.CardValue = cardValue;
            this.myImage = myimage;
            this.myScore = myscore;
        }

        public void UpdateImage(Card card)
        {
            Uri fileUri = new Uri(card.FilePath, UriKind.Relative);
            this.myImage.Source = new BitmapImage(fileUri);
                
        }

        public bool Hit(Queue<Card> deck)
        {
            var busted = false;
            this.currentCard = deck.Dequeue();
            UpdateImage(this.currentCard);
            busted = isBusted();
            return busted;
        }


        public bool isBusted()
        {
            this.CardValue += this.currentCard.Value;

            if (this.CardValue > 21 && this.currentCard.Value == 11)
            {
                this.CardValue -= 10;
                myScore.Content = CardValue.ToString();
                return false;
            }
            else if (this.CardValue <= 21)
            {
                myScore.Content = CardValue.ToString();
                return false;
            }
            else
            {
                myScore.Content = "BUST!";
                return true;
            }
        }

    }
}
