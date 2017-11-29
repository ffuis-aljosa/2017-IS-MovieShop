using MovieShop.Db;
using MovieShop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieShop
{
    public partial class AddMovieForm : Form
    {
        public Movie NewMovie { get; set; }

        public AddMovieForm()
        {
            InitializeComponent();
            loadGenres();
        }

        private void loadGenres()
        {
            List<Genre> genres = GenreRepository.fetchAllGenres();

            foreach (Genre genre in genres)
                genreComboBox.Items.Add(genre);
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewMovie = new Movie(
                    titleTextBox.Text, 
                    yearTextBox.Text, 
                    (Genre)genreComboBox.SelectedItem
                );

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
