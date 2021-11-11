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
        // skapar ett objekt av typen GameEngine
        GameEngine _game;
        public MainWindow()
        {
            InitializeComponent();
            _game = new GameEngine();
        }
        /// <summary>
        /// presenterar i gränssnittet
        /// </summary>
        /// <param name="dices"></param>
        private void DisplayDices(int[] dices)
        {
            txtDie1.Text = dices[0].ToString();
            txtDie2.Text = dices[1].ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            int[] dices;
            dices = _game.RollDices();
            DisplayDices(dices);
            // Vi vill presentera våra tärningar i gränssnittet
            // -->  varför inte skapa en metod?
            /*

            // deklarerar variabler av datatypen integer = heltal
            int ones, twos, threes, fours, fives, sixes;

            // hämta värdet från textboxen och lagra i variabel

            // för att detta ska fungera måste vi konvertera vår datatyp
            // från string to int
           
            ones = int.Parse(txtOnes.Text);
            twos = int.Parse(txtTwos.Text);

            // beräkna totalsumman
            total = ones + twos;

            */
            
        }

        private void btnOnes_Click(object sender, RoutedEventArgs e)
        {
            int ones;
            ones = int.Parse(txtOnes.Text);
            if (ones % 1 != 0 || ones > 5)
            {
                MessageBox.Show("Din poängsumma är felaktig");
            }
            // validera datat

        }

        private void btnTwos_Click(object sender, RoutedEventArgs e)
        {
            int score;
            score = int.Parse(txtTwos.Text);

            // poängen är rätt, när
            // totalsumman är mindre än ett maxvärde
            // dessutom jämnt delbart med 2

            if (_game.SaveScore(score,2))
            {
                MessageBox.Show("Dina poäng är registrerade");
            }
            else
            {
                MessageBox.Show("Kontrollera poängsumman. Något är felaktigt");
            }

        }
    }
}
