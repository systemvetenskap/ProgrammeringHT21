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

namespace Yahtzee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // deklarerar variabler av datatypen integer = heltal
            int ones, twos, threes, fours, fives, sixes, total=0;

            // hämta värdet från textboxen och lagra i variabel

            // för att detta ska fungera måste vi konvertera vår datatyp
            // från string to int
           
            ones = int.Parse(txtOnes.Text);
            twos = int.Parse(txtTwos.Text);

            // beräkna totalsumman
            total = ones + twos;

            // presentera värdet till scorekortet
            txtTotal.Text = total.ToString();
            
        }
    }
}
