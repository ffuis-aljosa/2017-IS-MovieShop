using System;

namespace MovieShop.Models
{
    class Genre
    {
        private int id;
        private string name;

        public Genre(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public Genre(string name)
        {
            Name = name;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Naziv žanra ne može biti prazan");

                if (value.Length > 32)
                    throw new Exception("Naziv žanra ne može biti duži od 32 karaktera");

                name = value;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
