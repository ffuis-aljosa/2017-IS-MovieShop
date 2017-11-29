using MovieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop
{
    public class Movie
    {
        private int id;
        private string title;
        private int year;
        private Genre genre;

        public Movie(int id, string title, int year, Genre genre)
        {
            this.id = id;
            Title = title;
            Year = year;
            Genre = genre;
        }

        public Movie(string title, string year, Genre genre)
        {
            Title = title;
            Genre = genre;

            int yearInt;
            bool parseSuccessful = int.TryParse(year, out yearInt);

            if (!parseSuccessful)
                throw new Exception("Neispravna godina produkcije");

            Year = yearInt;
        }

        public int Id {
            get
            {
                return id;
            }
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

        public Genre Genre {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public override string ToString()
        {
            return title + " " + year + " " + genre.Name;
        }
    }
}
