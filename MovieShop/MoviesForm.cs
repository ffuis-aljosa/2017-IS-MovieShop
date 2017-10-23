using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieShop
{
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                Movie newMovie = new Movie(titleTextBox.Text, yearTextBox.Text, genreComboBox.Text);
                moviesListBox.Items.Add(newMovie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
