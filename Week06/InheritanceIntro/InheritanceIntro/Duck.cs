using System.Windows;

namespace InheritanceIntro
{
    public class Duck : Animal
    {
        public void Quack()
        {
            MessageBox.Show("Quack");
        }
        public Duck(int height, string name)
        {
            this.Height = height;
            this.Name = name;
        }

        public Duck()
        {
        }
    }
}

