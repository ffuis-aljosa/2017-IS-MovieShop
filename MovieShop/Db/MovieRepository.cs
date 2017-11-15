using MovieShop.Models;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace MovieShop
{
    class MovieRepository
    {
        private static DbConnection connection = DbConnection.Instance;

        public static List<Movie> fetchAllMovies()
        {
            List<Movie> movies = new List<Movie>();

            string sql = 
                @"SELECT m.id, m.title, m.year, m.genre_id, g.name 
                  FROM movies AS m JOIN genres AS g ON m.genre_id = g.id";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string title = reader.GetString(1);
                int year = reader.GetInt32(2);
                int genreId = reader.GetInt32(3);
                string genreName = reader.GetString(4);

                Movie newMovie = new Movie(id, title, year, new Genre(genreId, genreName));
                movies.Add(newMovie);
            }

            return movies;
        }

        public static void createMovie(Movie movie)
        {
            string sql = "INSERT INTO movies(title, year, genre_id) VALUES " +
                    "('" + movie.Title + "', " + movie.Year + ", " + movie.Genre.Id + ")";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}
