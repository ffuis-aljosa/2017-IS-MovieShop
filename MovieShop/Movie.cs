using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    class Movie
    {
        private string title;
        private int year;
        private string genre;

        public Movie(string title, int year, string genre)
        {
            Title = title;
            Year = year;
            Genre = genre;
        }

        public Movie(string title, string year, string genre)
        {
            Title = title;
            Genre = genre;

            int yearInt;
            bool parseSuccessful = int.TryParse(year, out yearInt);

            if (!parseSuccessful)
                throw new Exception("Neispravna godina produkcije");

            Year = yearInt;
        }

        public string Title {
            get
            {
                return title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Naslov filma ne može biti prazan");

                title = value;
            }
        }

        public int Year {
            get
            {
                return year;
            }
            set
            {
                if (value < 1700 || 2100 < value)
                    throw new Exception("Neispravna godina produkcije");

                year = value;
            }
        }

        public string Genre {
            get
            {
                return genre;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Žanr filma ne može biti prazan");

                genre = value;
            }
        }

        public override string ToString()
        {
            return title + " " + year + " " + genre;
        }
    }
}
