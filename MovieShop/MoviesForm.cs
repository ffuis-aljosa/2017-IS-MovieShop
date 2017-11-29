using MovieShop.Db;
using MovieShop.Models;
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
            AddMovieForm addMovieForm = new AddMovieForm();
            DialogResult result = addMovieForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MovieRepository.createMovie(addMovieForm.NewMovie);
                loadMovies();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();

            usersForm.Show();
        }
    }
}
