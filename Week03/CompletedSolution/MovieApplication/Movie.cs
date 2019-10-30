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
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public double ReviewScore { get; set; }
        public double Length { get; set; }
        public string FilePath { get; set; }
        


        public List<string> Actors;

        public Movie(string title, string genre, double reviewScore, string director, double length, string filePath) {
            Title = title;
            Genre = genre;
            ReviewScore = reviewScore;
            Director = director;
            Length = length;
            FilePath = filePath;

        }

        public void DisplayInformation()
        {
            MessageBox.Show($"Title: {Title} \n Genre:{Genre} \n ReviewScore:{ReviewScore} \n Length:{Length} \n Director:{Director} \n FilePath:{FilePath}");
        }
    }
}
