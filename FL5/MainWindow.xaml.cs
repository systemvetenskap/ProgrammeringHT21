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

namespace FL5
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
            int chickenLegCount = 2, cowLegCount = 4, pigLegCount = 4, totalLegCount;

            // arrayer
            // Det är en variabel
            // så vi måste ange datatyp och namn

            int numberOfCows = 3;

            // En array är en samling data av samma datatyp
            // vi lägger på en []
            // deklarerar en array av typen int
            int[] animalCount;

            // objektorientering. Vi måste skapa ett nytt objekt
            animalCount = new int[3];
            // vår array måste ha en storlek
            // hur många fack (lådor) ska vår array få?

            // vi kommer åt ett facks värde, med index
            // men, vi räknar alltid från 0
            // låt oss tilldela tre värden
            animalCount[0] = 2;
            animalCount[1] = 3;
            animalCount[2] = 5;

            animalCount[0] = 5;
            animalCount[1] = 2;
            animalCount[2] = 8;


            // vi kan tilldela värden i en initalizer

            // alltså i samband med att vi skapar arrayen
            animalCount = new int[]
            {
                1,2,3
            };

            int middle = animalCount[1];
            
            
            
            // MessageBox.Show($"Jag har följande tre värden: {animalCount[0]*chickenLegCount}, {animalCount[1]*cowLegCount}, {animalCount[2]*pigLegCount}");

        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            // Slumpa tal
            // Först skapar vi vår slumpgenerator
            Random random = new Random();

            // skapa ett slumpmässigt tal
            int magicNumber;

            // slumpa värde från 0 --> 5 (Alla värden ska vara med)
            magicNumber = random.Next(6); // Exclusive upper bound
            magicNumber = random.Next(1, 6); // Exclusive upper bound 1.. 5


        }
    }
}
