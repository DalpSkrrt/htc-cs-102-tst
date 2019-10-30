using System.Collections.Generic;
using System.Windows;

namespace InheritanceIntro
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

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog(24, "Fred");
            dog.Bark();
        }
        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck(12, "Frederick");
            duck.Quack();
        }
        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();

            // Instantiate some dog objects
            Dog dog1 = new Dog(20, "Rolf");
            Dog dog2 = new Dog(30, "Air Bud");

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.SayName();
            }
            Duck duck = new Duck(18, "Ducker");
            duck.SayName();
        }
    }
}
