using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieShop
{
    public partial class MoviesForm : Form
    {
        SqlCeConnection dbConnection;
        string connectionString = @"Data Source=..\..\MovieShop.sdf;Password=StrongPassword";

        public MoviesForm()
        {
            dbConnection = new SqlCeConnection(connectionString);
            dbConnection.Open();

            InitializeComponent();

            loadMovies();
        }

        private void loadMovies()
        {
            SqlCeCommand command = new SqlCeCommand("SELECT Title, Year, Genre FROM Movies", dbConnection);
            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string title = reader.GetString(0);
                int year = reader.GetInt32(1);
                string genre = reader.GetString(2);

                Console.WriteLine(title + year + genre);

                Movie newMovie = new Movie(title, year, genre);
                moviesListBox.Items.Add(newMovie);
            }
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
