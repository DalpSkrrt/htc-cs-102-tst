using System.Windows;

namespace InheritanceIntro
{
    public class Animal
    {
        public int Height;
        public string Name;

        public void SayName()
        {
            MessageBox.Show($"My name is {Name}");
        }
    }
}
