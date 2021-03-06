using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            var player = new Player(0, PlayerCard, PlayerScore);
            var dealer = new Dealer(0, DealerCard, DealerScore);
            var deck = new Queue<Card>();
            var playerTurn = true;
            var dealerDone = false;
            deck = DeckMethods.DeckAssembler();
            deck = DeckMethods.MultiShuffler(deck);
            deck = DeckMethods.Cut(deck);
            Welcome welcome = new Welcome();

            welcome.ShowDialog();
            this.Show();
            player.Name = welcome.nameBox.Text;
            PlayerTotal.Content = $"{player.Name} Total";
            while(playerTurn == true)
            {
                var message = "Would you like to hit?";
                var caption = "Player turn";
                MessageBoxButton buttons = MessageBoxButton.YesNo;

                var result = MessageBox.Show(message, caption, buttons);
                if (result == MessageBoxResult.No)
                {
                    playerTurn = false;
                    continue;
                }

                player.Hit(deck);
                updateImage(player);
                if (player.CardValue > 21)
                {
                    playerTurn = false;
                    continue;
                }
                
            }
            
            while (!dealerDone)
            {
                var toHit = dealer.HitOrStand();
                if (!toHit)
                {
                    updateDealerImage(dealer);
                    break;
                }
                dealer.Hit(deck);
                updateDealerImage(dealer);
            }
            CheckWinner(player, dealer);

            // Methods to update control objects
            void updateImage(Player player)
            {
                PlayerCard.Source = (ImageSource)FindResource(player.currentCard.FilePath);
            }
            void updateDealerImage(Player dealer)
            {
                DealerCard.Source = (ImageSource)FindResource(dealer.currentCard.FilePath);
            }
            void CheckWinner(Player player, Player dealer)
            {
                if(player.CardValue > 21 && dealer.CardValue > 21)
                {
                    Winner.Content = "Both busted; no winner.";
                    Winner.Visibility = Visibility.Visible;
                }
                else if(player.CardValue > 21)
                {
                    Winner.Content = $"Dealer is the winner!";
                    Winner.Visibility = Visibility.Visible;
                }
                else if(dealer.CardValue > 21)
                {
                    Winner.Content = $"{player.Name} is the winner!";
                    Winner.Visibility = Visibility.Visible;
                }
                else if(player.CardValue == dealer.CardValue)
                {
                    Winner.Content = "Player and dealer tied; no winner.";
                    Winner.Visibility = Visibility.Visible;
                }
                else if(player.CardValue > dealer.CardValue)
                {
                    Winner.Content = $"{player.Name} is the winner!";
                    Winner.Visibility = Visibility.Visible;
                }
                else if(player.CardValue < dealer.CardValue)
                {
                    Winner.Content = $"Dealer is the winner!";
                    Winner.Visibility = Visibility.Visible;
                }

            }

            
           
           
        }

        
        //public string InitGame()
        //{
        //    var message = "Welcome to the Kirk Casino! We are currently cashless but looking" +
        //                   "forward to playing Black Jack with you today! Please enter your name:";
        //    var caption = "Let's Play BlackJack!";
            
        //    MessageBoxResult result;

        //    result = MessageBox
            
        //}
        
        //public void UpdateScore(Player player)
        //{
        //    PlayerScore.Content = player.CardValue;
        //}

       
    }
}
