using System;
using System.Collections.Generic;
using System.IO;
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

namespace FL7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people = new List<Person>();
        Farm farm;

        
        public MainWindow()
        {
            people = FileHandler.Open<List<Person>>("people.json");
            List<Animal> animals = new List<Animal>()
            {
                new Cow()
            };

            Animal pig = new Pig();
            animals.Add(pig);
            FileHandler.Save(animals, "test.hsf");
            InitializeComponent();
            if (!File.Exists("farm.json"))
            {
                farm = new Farm(10)
                {
                    Address = "Landsvägen 2",
                    Name = "Höjda"
                };

                FileHandler.Save(farm, "farm.json");
            }
            else
            {
                farm = FileHandler.Open<Farm>("farm.json");
            }
            Cow cow = farm.GetCowById(5);
            if (cow == null)
            {
                MessageBox.Show("Hittade ingen ko med det id-numret");
            }
            lstPeople.ItemsSource = farm.Cows;
            
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int dayOfBirth = int.Parse(txtAge.Text);

            Person person = new Person
            {
                Name = name,
                BirthYear = dayOfBirth
            };
            people.Add(person);

            UpdateListbox();
            FileHandler.Save(people, "people.json");

        }

        private void UpdateListbox()
        {
            lstPeople.ItemsSource = null;
            lstPeople.ItemsSource = people;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            Animal animal;

            // Solid
            // Liskow subsitution principle
            Animal animal2 = new Chicken("Agda");


            animal = new Pig("Adgda");



            //bool success = farm.AddAnimal(animal);


            //Animal pig = new Animal
            //{
            //    Type = "Gris",
            //    NumberOfLegs = 4
            //};

            //Animal pig2 = new Animal
            //{
            //    Type = "Gris",
            //    NumberOfLegs = 4
            //};

            //Animal chicken = new Animal()
            //{
            //    NumberOfLegs = 2,
            //    Type = "Höna"
            //};

            // int totalLegs = pig.NumberOfLegs + chicken.NumberOfLegs;
            // djurens antal ben i en lista
            List<int> legCount = new List<int>();
            legCount.Add(2);
            legCount.Add(4);
            legCount.Add(2);

            // Nu vill vi samla bondens alla djur i en lista
            

            List<string> animalTypesInFarm = GetAnimalTypes(animals);

            GetAnimalSounds(animals);
        }


        public int CountTotalLegs(List<Animal> animals)
        {
            // Eriks lilla minnesregel
            // när du har en lista .... tänk loop
            int total = 0;

            foreach (Animal animal in animals)
            {
                total += animal.NumberOfLegs;
            }

            return total;
        }

        public List<string> GetAnimalTypes(List<Animal> animals)
        {
            List<string> types = new List<string>();
            foreach (Animal animal in animals)
            {
                types.Add(animal.Type);
            }

            return types;
        }
        
   






        public void GetAnimalSounds(List<Animal> aninmals)
        {
            foreach (Animal animal in aninmals)
            {
                MessageBox.Show(animal.MakeSound());
            }
        }

        private void btnGetPerson_Click(object sender, RoutedEventArgs e)
        {
            Person selectedPerson = lstPeople.SelectedItem as Person;
            selectedPerson.Name = "Ändrat";

            bool isVowel = selectedPerson.IsVowel('E');
            UpdateListbox();
            MessageBox.Show(selectedPerson.SayHello());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Animal animal;
            bool success;
            
            animal = new Cow();
           // success = farm.AddAnimal(animal);

            animal = new Chicken();
            //            success = farm.AddAnimal(animal);
            success = true;

            if (!success)
            {
                MessageBox.Show("Du har nått maxgränsen för antal djur");
            }
            UpdateAnimalList();
            // nu vill vi se djuren på bondgården
            //farm.Animals.Add(animal);
        }

        private void UpdateAnimalList()
        {
            lstPeople.ItemsSource = null;
            lstPeople.ItemsSource = farm.GetAnimalsWithTwoLegs();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Animal animal1 = new Pig();
            Animal animal2 = new Cow();

            animal1 = animal2;

            animal1.Name = "Erik";

        }
    }
}
