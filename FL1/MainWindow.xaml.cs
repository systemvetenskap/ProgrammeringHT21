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
        // IDE
        private void btnMessage2_Click(object sender, RoutedEventArgs e)
        {
            // Int = integer = heltal
            // alla datatyper har ett grundvärde, default
            int number;

            number = 5;
            // grundläggande operationer
            number = 2 + 8;

            number = 2 - 8;

            string test = "3";
            test = "5b";

            // konvertering av datatyp
            // Vi använder metoden ToString
            // den kräver ALLTID parentes
            MessageBox.Show(number.ToString());

        }


        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            // Variabler
            // förråd för värden i vårt program

            // C# är ett så kallat hårt typat program

            // Vi måste alltid ange datatyp
            // vilken typ av värde kommer vår variabel att få?

            // deklarerar variabel

            // datatyp [mellanslag] namnet på variabeln
            // koda på engelska
            // pascal casing
            // = första bokstaven är ALLTID liten i en variabel
            // sammansatta ord --> stor bokstav på nästa ord
            string name, fullName, adress="Sågstigen 1";
           // string fullName;

            // tilldelar vi värde till variabeln

            name = "Erik";
            //MessageBox.Show(name);
            //name = name + " Öberg";
            // En dialogruta
            // använd variabeln

            //name = "Öberg";  // skrev över värdet
            // Utöka värdet i variabeln
            fullName = name +" "+ "Öberg" + " " + adress;

            // ett annat sätt att göra samma sak är interpolation
            fullName = $"Jag heter {name} och bor på {adress}";
            // variabler tilldelas värden från höger till vänster
            MessageBox.Show(fullName);



            // kräver metoden Show för att fungera
            // ALLA metoder kräver () parenteser
            // En metod visas med en liten låda i Visual Studio

            // Måsvinge {    }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // variabel

            string name;
            // tilldela värdet från textboxen
            // Egenskaper kan nästan alltid både presentera och ändra värde

            // Egenskap = property
            // Get, set
            // Get = hämta värde

            // hämta värde från textboxen
            // tilldela detta värde till vår variabel

            // txtFirstname är ett objekt
            // objekt kan ha egenskaper
            name = txtFirstname.Text;

            // Tilldela vår variabel till gränssnittet.
            txtResult.Text = name;
            lblResult.Content = name;
        }
    }
}
