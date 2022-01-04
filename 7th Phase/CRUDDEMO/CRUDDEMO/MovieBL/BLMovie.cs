using System;
using System.Collections.Generic;
using CRUDDEMO.Models;
using MySql.Data.MySqlClient;

namespace CRUDDEMO.MovieBL
{
    public class BLMovie
    {
        public static List<Movie> listMovies()
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
                finally
                {
                    con.Close();
                }

            }
            return movies;
        }
        public static Movie SelectMovieByID(int id)
        {
            Movie movie = new Movie();
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from mydatabase.movies where movieID=" + id, con);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movie.MovieId = id;
                            movie.MovieName = reader["movieName"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    con.Close();
                }

            }
            return movie;
        }

        public static string insertMovie(Movie movie)
        {
            if (movie.MovieName != null)
            {
                using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
                {

                    try
                    {
                        con.Open();

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = con;
                            if (movie.MovieId == 0)
                            {
                                cmd.CommandText = "insert into mydatabase.movies (movieName) values ('" + movie.MovieName + "')";
                            }
                            else
                            {
                                cmd.CommandText = "update mydatabase.movies set movieName='" + movie.MovieName + "' where movieID=" + movie.MovieId;
                            }
                            int rowCount = cmd.ExecuteNonQuery();
                            if (rowCount > 0)
                            {
                                return "SUCCESS";
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }

            }


            return "Something Wrong";
        }

        public static string deleteMovie(int id)
        {
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {

                try
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand("delete from mydatabase.movies where movieID=" + id, con))
                    {
                        int rowCount = cmd.ExecuteNonQuery();
                        if (rowCount > 0)
                        {
                            return "SUCCESS";
                        }
                    }
                }

                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return "Something gone wrong";
        }




    }

}
