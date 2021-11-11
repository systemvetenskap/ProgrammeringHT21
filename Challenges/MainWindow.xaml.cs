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

namespace Challenges
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

        private void btnOkl_Click(object sender, RoutedEventArgs e)
        {
            // Vi ska testa AND operatorn
            // den validerar sant om båda uttrycken är sanna
            // annars falskt

            bool a, b;

            // hämtar värden från gränssnittet
            a = (bool)chkA.IsChecked;
            b = (bool)chkB.IsChecked;

            // varför (bool)? Jo för att vi måste även kolla om den är orörd
            // three level state, sann falsk orörd.
            // ? betyder egentligen null

            if (a && b)
            {
                MessageBox.Show("Uttrycket är sant");
            }
            else
            {
                MessageBox.Show("Uttrycket är falskt");
            }

            if (a || b) // logiskt eller
            {
                MessageBox.Show("Uttrycket är sant, no 2");
            }
            else
            {
                MessageBox.Show("Uttrycket är falskt, no2");
            }
        }

        private void btnPerimiter_Click(object sender, RoutedEventArgs e)
        {
            // Vilka data behöver vi för att lösa uppgiften?
            // datatyp
            // Vi kan använda heltal, = integer

            int length=6, height=7, perimiter;

            perimiter = length + length + height + height;
            
            
            perimiter = length *2  + height *2;
        }

        private void btnFarmer_Click(object sender, RoutedEventArgs e)
        {
            // Vad ska vi göra???
            /*
            chickens = 2 legs
            cows = 4 legs
            pigs = 4 legs
            */
            int chickenLegCount = 2, cowLegCount = 4, pigLegCount = 4, totalLegCount;

            int numberOfChickens, numberOfCows, numberOfPigs;

            numberOfChickens = 1;
            numberOfCows = 2;
            numberOfPigs = 3;

            totalLegCount = chickenLegCount * numberOfChickens + numberOfCows * cowLegCount + numberOfPigs * pigLegCount;

            // Det här sättet känns ju bara lite väl mycket, eller?
            // kan man inte gruppera variabler istället?
            // jo, genom att använda arrayer

        }

        private void btnHurdleJump_Click(object sender, RoutedEventArgs e)
        {
            int jumpHeight = 5;

            int[] hurdles = new int[] {1,2,1,5 };
            /*
            if (jumpHeight >= hurdles[0] && jumpHeight >= hurdles[1] && jumpHeight >= hurdles[2])
            {
                MessageBox.Show("Yes, du klarade alla hinder");
            }
            else
            {
                MessageBox.Show("Nej, du kom inte över hindren");
            }*/

            // En mycket bra kompis till en array är en loop
            // det finns massa olika typer av loopar
            // Vi börjar med foreach
            // för varje, en supersmart loop när man vill titta på alla värden i en array, ett i taget
            bool isSuccess = true;
           
            foreach (int hurdleHeight in hurdles)
            {
                if (jumpHeight < hurdleHeight)
                {
                    // klarade INTE hindret
                    isSuccess = false; // vi sätter en flagga
                }
            }

            if (isSuccess)
            {
                MessageBox.Show("ja");
            }
            else
            {
                MessageBox.Show("nej");

            }

        }

        private bool IsEven(int number) =>  number % 2 == 0;


        private string NameShuffle(string fullName)
        {
            // en sträng är alltså en array of chars
            int numberOfChars = fullName.Length;
            // " dubbelfnutt = sträng
            // ' enkelfnutt = tecken
            string firstName = "", lastName="";
            bool foundWhiteSpace = false;
            // for (int i = numberOfChars-1; i >= 0; i--)
            for (int i = 0; i < numberOfChars; i++)
            {
                if (IsEven(i))
                {

                }
                char activeChar = fullName[i];
                if (char.IsWhiteSpace(activeChar))
                {
                    foundWhiteSpace = true;
                    continue;
                }
                if (!foundWhiteSpace)
                {
                    firstName += activeChar.ToString();
                }
                else
                {
                    lastName += activeChar.ToString();
                }
            }
            return $"{lastName} {firstName}";
           // string[] nameParts = fullName.Split(" ");
            // return $"{nameParts[1]} {nameParts[0]}";
        }

        private double AverageWordLength(string sentence)
        {
            double mean = 0;
            int words = 1, charCount=0;
            // What a gorgeous day.
            foreach (char c in sentence)
            {
                if (char.IsWhiteSpace(c))
                {
                    words++;
                }
                else if(char.IsLetterOrDigit(c))
                {
                    charCount++;
                }
            }
            mean = charCount / (double)words;
            return mean;
        }

        private void btnNameShuffle_Click(object sender, RoutedEventArgs e)
        {
            string name = NameShuffle("Pelle plutt");
        }

        private void btnAvgWord_Click(object sender, RoutedEventArgs e)
        {
            double average = AverageWordLength("What a gorgeous day.");
        }
    }
}
