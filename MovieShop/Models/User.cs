using System;
using System.Security.Cryptography;
using System.Text;

namespace MovieShop.Models
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Korisničko ime ne može biti prazno");

                if (value.Length > 100)
                    throw new Exception("Korisničko ime ne može biti duže od 100 karaktera");

                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 6)
                    throw new Exception("Lozinka mora da ima bar 6 karaktera");

                using (SHA256 sha = new SHA256Managed())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(value);
                    byte[] hashedPassword = sha.ComputeHash(passwordBytes);

                    password = Convert.ToBase64String(hashedPassword);
                }
            }
        }
    }
}
