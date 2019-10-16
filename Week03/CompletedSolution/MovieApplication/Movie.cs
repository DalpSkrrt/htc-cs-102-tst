using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieApplication
{
    public class Movie
    {
        public string Title;
        public List<string> Actors;
        public string Genre;
        public double ReviewScore;

        public Movie(string title, string genre, double reviewScore) {
            Title = title;
            Genre = genre;
            ReviewScore = reviewScore;
        }

        public void DisplayInformation()
        {
            MessageBox.Show($"Title: {Title} \n Genre:{Genre} \n ReviewScore:{ReviewScore}");
        }
    }
}
