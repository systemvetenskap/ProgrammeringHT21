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

namespace FL11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();

            Calculator.Sum(34, 56);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            string value = "4,9";

            double value1 = double.Parse(value);
            // undvika skriva kod här
            double sum = Calculator.Sum(value1, value1);
            int x=3, y=4;
            int sum1 = Calculator.Sum(x,y);

            double[] values = new double[] { 2.3, 4, 7.9 };
            sum = Calculator.Sum(values);
        }
    }
}
