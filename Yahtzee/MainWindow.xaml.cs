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
        int total = 0, bonus=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // deklarerar variabler av datatypen integer = heltal
            int ones, twos, threes, fours, fives, sixes;

            // hämta värdet från textboxen och lagra i variabel

            // för att detta ska fungera måste vi konvertera vår datatyp
            // från string to int
           
            ones = int.Parse(txtOnes.Text);
            twos = int.Parse(txtTwos.Text);

            // beräkna totalsumman
            total = ones + twos;

            
            
        }

        private void btnOnes_Click(object sender, RoutedEventArgs e)
        {
            int ones;
            ones = int.Parse(txtOnes.Text);
            // hämtar värdet från total
            // och ökar sedan detta värde med vår poäng för ettor
            total += ones;

            // presentera värdet till scorekortet

            // Undersök om totalpoängen ger mig bonus
            // Vi låtsas: Bonus om total är 10 poäng eller mer
            // --> bonus = 50p
            // annars bonus 0p

            // vi gör en if-sats
            // inom parentes sätter vi ett villkor
            // detta måste valideras som sant eller falskt
            if (total >= 10)
            {
                bonus = 50;
                total += bonus;
                txtBonus.Text = bonus.ToString();
            }
            txtTotal.Text = total.ToString();
        }

        private void btnTwos_Click(object sender, RoutedEventArgs e)
        {
            int score;
            score = int.Parse(txtTwos.Text);
            total += score;

            // presentera värdet till scorekortet
            txtTotal.Text = total.ToString();
        }
    }
}
