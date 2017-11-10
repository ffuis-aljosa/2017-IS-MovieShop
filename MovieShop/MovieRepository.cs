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

            string sql = "SELECT Title, Year, Genre FROM Movies";
            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);

            SqlCeDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string title = reader.GetString(0);
                int year = reader.GetInt32(1);
                string genre = reader.GetString(2);

                Movie newMovie = new Movie(title, year, genre);
                movies.Add(newMovie);
            }

            return movies;
        }

        public static void createMovie(Movie movie)
        {
            string sql = "INSERT INTO movies(title, year, genre) VALUES " +
                    "('" + movie.Title + "', " + movie.Year + ", '" + movie.Genre + "')";

            SqlCeCommand command = new SqlCeCommand(sql, connection.Connection);
            command.ExecuteNonQuery();
        }
    }
}
