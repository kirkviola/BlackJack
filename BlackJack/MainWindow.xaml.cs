using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
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
            deck = DeckMethods.DeckAssembler();
            deck = DeckMethods.MultiShuffler(deck);
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
                }

                player.Hit(deck);
                
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
