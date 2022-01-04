using System;
using System.Collections.Generic;
using CRUDDEMO.Models;
using MySql.Data.MySqlClient;

namespace CRUDDEMO.MovieBL
{
    public class BLMovie
    {
        public List<Movie> listMovies()
        {
            List<Movie> movies = new List<Movie>();
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from mydatabase.movies", con);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie()
                            {
                                MovieId = Convert.ToInt32(reader["movieID"]),
                                MovieName = reader["movieName"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
            return movies;
        }




    }

}
