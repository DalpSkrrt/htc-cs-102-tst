using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;
        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();

            Frog frog = new Frog(4, "Bart", true, 2);
            Dog dog = new Dog("Golden Retriever", 34,"Charlie", 86);
            Duck duck = new Duck(18, "Donald", 10);

            Animals.Add(frog);
            Animals.Add(duck);
            Animals.Add(dog);

            lvAnimals.ItemsSource = Animals;
        }

 

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
             
            }
        }

        private void lvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
