using System;
using System.Collections.Generic;
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
using BlackJackLib;

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
            var player = new Player(0, PlayerCard);
            var dealer = new Dealer(0, DealerCard);
            var deck = new Queue<Card>();
            var playerTurn = true;
            deck = DeckMethods.DeckAssembler();
            deck = DeckMethods.MultiShuffler(deck);

            InitGame();

            //while (playerTurn)
            //{
            //    Stand.Click += new EventHandler(this.StandClick);
            //}
        }

        private bool StandClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.IsEnabled = false;
            Hit.IsEnabled = false;
            return false;
        }

        public bool InitGame()
        {
            var message = "Welcome to the Kirk Casino! We are currently cashless but looking" +
                           "forward to playing Black Jack with you today! Would you like to play?";
            var caption = "Let's Play BlackJack!";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxResult result;

            result = MessageBox.Show(message, caption, button);
            if (result == MessageBoxResult.Yes)
                return true;
            else
                Close();
            return false;
        }
        
        public void UpdateScore(Player player)
        {
            PlayerScore.Content = player.CardValue;
        }

        
    }
}
