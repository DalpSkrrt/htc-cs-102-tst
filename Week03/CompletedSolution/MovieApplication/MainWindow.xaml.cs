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

namespace MovieApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection <Movie> movieList = new ObservableCollection<Movie>();

        public MainWindow()
        {
            InitializeComponent();
            movieListView.ItemsSource = movieList;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submitMovieButton_Click(object sender, RoutedEventArgs e)
        {
            
            Movie submittedMovie = new Movie(titleTextBox.Text, genreTextBox.Text, Double.Parse(reviewScoreTextBox.Text), directorTextBox.Text, Double.Parse(lengthTextBox.Text), filePathTextBox.Text);
            movieList.Add(submittedMovie);
           // submittedMovie.DisplayInformation();
            titleTextBox.Clear();
            genreTextBox.Clear();
            reviewScoreTextBox.Clear();
            directorTextBox.Clear();
            lengthTextBox.Clear();
            filePathTextBox.Clear();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void movieListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = movieListView.SelectedItem as Movie;
            currentTextBlock.Text = selectedMovie.Title;
            currentPoster.Source = new BitmapImage(new Uri(selectedMovie.FilePath));
           
        }
    }
}
