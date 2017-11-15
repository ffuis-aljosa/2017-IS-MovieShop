using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
            SHA256 sha = new SHA256Managed();

            byte[] hashedPassword = sha.ComputeHash(
                Encoding.UTF8.GetBytes(passwordTextBox.Text)
                );

            Console.WriteLine(BitConverter.ToString(hashedPassword));

            sha.Dispose();
        }
    }
}
