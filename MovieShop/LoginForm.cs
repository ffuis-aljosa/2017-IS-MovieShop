using MovieShop.Db;
using MovieShop.Models;
using System;
using System.Windows.Forms;

namespace MovieShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(usernameTextBox.Text, passwordTextBox.Text);

                if (UserRepository.login(user))
                {
                    MoviesForm moviesForm = new MoviesForm();
                    moviesForm.Show();

                    moviesForm.FormClosed += MoviesForm_FormClosed;

                    Hide();
                }
                else
                {
                    throw new Exception("Korisničko ime i/ili lozinka su pogrešni");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void MoviesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
