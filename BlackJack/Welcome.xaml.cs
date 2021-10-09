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
using System.Windows.Shapes;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();


        }

        public string GetName()
        {
            if (nameBox.Text == "")
                return "Player";
            else
                return nameBox.Text;
        }

        public void Play_Click(object sender, RoutedEventArgs e)
        {
            
            var name = GetName();
            this.Close();
        }
    }
}
