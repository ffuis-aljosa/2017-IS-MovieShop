using MovieShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Db
{
    class GenreRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static List<Genre> fetchAllGenres()
        {
            List<Genre> genres = new List<Genre>();

            string sql = "SELECT id, name FROM genres";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["name"];
                int id = (int)reader["id"];

                Genre genre = new Genre(id, name);
                genres.Add(genre);
            }

            return genres;
        }
    }
}
