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

namespace Metoder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void DisplayMessage(string message)
        {
            // MessageBox.Show(message);
            MessageBox.Show(message, "rubrik",MessageBoxButton.OKCancel,MessageBoxImage.Hand);
        }
        /// <summary>
        /// Kontrollerar om jag kan hoppa över alla häckar i ett häcklopp
        /// </summary>
        /// <param name="hurdles">Häckar</param>
        /// <param name="jumpHeight">Höjd jag hoppar, decimaltal</param>
        /// <returns>true om alla häckar kan passeras</returns>
        private bool HurdleJump(int[] hurdles, double jumpHeight)
        {
            for (int i = 0; i < hurdles.Length; i++)
            {
                if (jumpHeight < hurdles[i])
                {
                    return false;
                }

            }
            return true;
        }
        /// <summary>
        /// slumpmässig hopphöjd
        /// </summary>
        /// <param name="hurdles"></param>
        /// <returns></returns>
        private bool HurdleJump(int[] hurdles)
        {
            for (int i = 0; i < hurdles.Length; i++)
            {
                int jumpHeight = random.Next(1, 10);
                if (jumpHeight < hurdles[i])
                {
                    return false;
                }

            }
            return true;
        }
        private bool HurdleJump(int[] hurdles, int jumpHeight)
        {
            
            for (int i = 0; i < hurdles.Length; i++)
            {
                if (jumpHeight < hurdles[i])
                {
                    return false;
                }
                
            }
            return true;
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            int[] myHurdles = new int[] { 1, 2, 3, 4, 5 };
            bool success;
            // metodanrop
           success= HurdleJump(myHurdles, 1);
           success= HurdleJump(myHurdles, 2);
           success= HurdleJump(myHurdles, 3.4);
           success= HurdleJump(myHurdles, 4);
           success= HurdleJump(myHurdles, 5);
           success= HurdleJump(myHurdles);


            string message;
            message = "Erik Öberg";
            DisplayMessage(message);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int[] manyHurdles = new int[] { 5,4,5,6 };
            int myJumpHeight = 0;
            // metodanrop

            if(HurdleJump(manyHurdles, myJumpHeight))
            {
                MessageBox.Show("Jippi");
            }
            else
            {
                MessageBox.Show("Typiskt");
            }
        }
    }
}
