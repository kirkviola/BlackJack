using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Linq;

namespace BlackJack
{
    public class Dealer : Player
    {
        public Dealer(int value, System.Windows.Controls.Image image, System.Windows.Controls.Label score) 
            : base (value, image, score)
        {

        }
        public bool HitOrStand()
        {
            if (this.CardValue <= 16)
                return true;
            else
                return false;
        }

        public void DealerPlay(Queue<Card> deck)
        {
            var done = true;
            while (done)
            {
                isBusted();
                if (!HitOrStand())
                    break;

                this.Hit(deck);
            }
        }
    }
}
