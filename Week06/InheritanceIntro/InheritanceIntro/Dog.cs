using System.Windows;

namespace InheritanceIntro
{
    public class Dog : Animal
    {
        public void Bark()
        {
            MessageBox.Show("Bark");
        }
        public Dog(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }

        public Dog()
        {

        }
    }
}