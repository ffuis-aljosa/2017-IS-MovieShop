using MovieShop.Db;
using MovieShop.Models;
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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTextBox.Text != repeatPasswordTextBox.Text)
                    throw new Exception("Lozinka i ponovljena lozinka nisu iste");

                User user = new User(usernameTextBox.Text, passwordTextBox.Text);

                UserRepository.createUser(user);

                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                repeatPasswordTextBox.Text = "";

                MessageBox.Show("Korisnik uspješno kreiran");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
