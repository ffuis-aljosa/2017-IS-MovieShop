using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieShop
{
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();

            loadMovies();
        }

        private void loadMovies()
        {
            moviesListBox.Items.Clear();

            List<Movie> movies = MovieRepository.fetchAllMovies();

            foreach (Movie movie in movies)
                moviesListBox.Items.Add(movie);
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                Movie newMovie = new Movie(titleTextBox.Text, yearTextBox.Text, genreComboBox.Text);

                MovieRepository.createMovie(newMovie);

                loadMovies();

                titleTextBox.Text = "";
                yearTextBox.Text = "";
                genreComboBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
