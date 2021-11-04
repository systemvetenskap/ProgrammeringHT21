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

namespace FL4
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
            int age = 12, score=15;
            // ett = är att tilldela
            // dubbla = innebär att man jämför
            // three level state
            // Undersöker om man är under 15 år, alltså ett barn
            bool isAChild = (bool)chkChildren.IsChecked;   //age < 15;

            //varför en märklig parentes framför?
            // jo vi castar värdet
            // cast == typ att låtsas vara något annat
            // < <= > >=
            // ==
            // ! ett utropstecken vänder på ett uttryck
            if (age != 15)
            {
               
            }
            else if(isAChild)
            {

            }

            if (isAChild)
            {
                if (score >= 30)
                {

                }
            }


            // jag är polis
            bool isSober = false;
            bool hasCorrectSpeed = true;
            bool carIsSafe = false;

            if (!isSober)
            {

            }
            if (hasCorrectSpeed == false)
            {

            }
            if(!carIsSafe)
            { 
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string name = "Erik", name2="erik";
            // erik == 'e' 'r' 'i' 'k' 
            char sign, sign2 = 'e';

            string variabel;
            sign = 'E';

            // C# är case sensitive
            if (sign == sign2)
            {
                // de här bokstäverna är lika
            }
            else
            {
                // de är olika
            }

            if (name.ToLower() == name2.ToLower())
            {
                // de här namnen är lika
            }
            else
            {
                // de är olika
            }










            int count = 9;
            double decimaltal = 151;
            // när vi kodar i code behind. Använd punkter
            // double length = double.Parse(txtLength.Text);   //12.8;

            //Convert.to

            //count /= 2;
            //decimaltal /= 2;

            //decimaltal /= count;

            decimaltal = (int)decimaltal /2;

            //count = length;
            //length = count;
            
            //length *= 2;

            //MessageBox.Show(length.ToString());
        }
    }
}
