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

namespace Polymorfism
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Assignment assignment = new Assignment();
            Rectangle rectangle = new Rectangle
            {
                Height = 2.5,
                Width = 6
            };

            Triangle triangle = new Triangle
            {
                Width = 6,
                Height = 3
            };
            assignment.Shapes.Add(triangle);
            assignment.Shapes.Add(rectangle);

            MessageBox.Show($"Väggens area är: {assignment.CalculateTotalArea()} kvadratmeter");
        }
    }
}
