using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Linq;

namespace BlackJackLib
{
    public class Dealer : Player
    {
        public Dealer(int value, System.Windows.Controls.Image image) : base (value, image)
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
                done = isBusted();
                if (!HitOrStand() || done)
                    break;

                done = this.Hit(deck);
            }
        }
    }
}
