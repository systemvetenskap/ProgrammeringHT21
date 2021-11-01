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

namespace FL1
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

        private void btnMessage2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nu är den andra knappen klickad");
        }


        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            // Kodblock


            // En dialogruta
            MessageBox.Show("Hej världen");

            // kräver metoden Show för att fungera
            // ALLA metoder kräver () parenteser
            // En metod visas med en liten låda i Visual Studio

            // Måsvinge {    }
        }

        
    }
}
