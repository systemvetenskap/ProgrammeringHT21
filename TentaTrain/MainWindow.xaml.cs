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

namespace TentaTrain
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Waggon waggon = new Waggon(32);
            List<Seat> availableSeats = waggon.GetFreeSeats(35);
            availableSeats = waggon.GetFreeSeatPairs();
            lstSeats.ItemsSource = null;
            lstSeats.ItemsSource = availableSeats;

            int seatNumber = 9; // int.Parse(txtSeatNr.Text);
            int numberOfSeats = 16;

            bool isOutbound = (bool)rdoOut.IsChecked;
                
            bool    isHeadedFront;

            int breakLevel = numberOfSeats / 2;
            if (isOutbound)
            {
                if (seatNumber > breakLevel)
                {
                    // sitter på högra sidan
                    isHeadedFront = true;
                }
                else
                {
                    isHeadedFront = false;
                }
            }
            else
            {
                if (seatNumber > breakLevel)
                {
                    // sitter på högra sidan
                    isHeadedFront = false;
                }
                else
                {
                    isHeadedFront = true;
                }
            }
            string message;
            if (isHeadedFront)
            {
                message = "åker framlänges";
            }
            else
            {
                message = "åker baklänges";
            }
            
        }

        private void btnReturnTickets_Click(object sender, RoutedEventArgs e)
        {
            //int[] seatNumbers = { 2, 3, 5 };
            int[] seatNumbers = new int[] { 1, 4, 2 };

            Waggon waggon = new Waggon(34);

            waggon.ReturnTickets(seatNumbers);

        }
    }
}
