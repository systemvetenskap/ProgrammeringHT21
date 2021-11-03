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

namespace FL3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
           
            // tilldelar jag variabeln värdet 1
            //count = 1;

            // men jag vill ju öka med ett i taget

            //count = count + 1;
            
            
            count++;

            /*
            // Ännu ett sätt att räkna 
            // operator +, -, /, *
            count += 3;
            count -= 3;
            count /= 3;
            count *= 3;
            */
            MessageBox.Show(count.ToString());
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // if-sats
            int score = 11, bonus, age=10;


            if (age <= 12) // jag är ett barn
            {
                if (score >= 10)
                {
                    bonus = 20;
                }
                else
                {
                    bonus = 0;
                }
            }
            else // jag är vuxen
            {
                if (score >= 20)
                {
                    bonus = 20;
                }
                else
                {
                    bonus = 0;
                }
            }




            /*
            if(score >= 20)
            {
                bonus = 40;
            }
            else if (score >= 15)
            {
                bonus = 30;
            }
            else if(score >= 10)
            {
                bonus = 20;
            }
            else
            {
                bonus = 0;
            }*/
            /*
            if(score >= 0 && score <10)
            {
                bonus = 0;
            }
            */


            
            MessageBox.Show($"Grattis, du fick {bonus} extra poäng!");

            // if else
        }
    }
}
