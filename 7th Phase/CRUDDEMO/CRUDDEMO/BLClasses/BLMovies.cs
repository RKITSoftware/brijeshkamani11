using System;
using System.Collections.Generic;
using CRUDDEMO.Models;
using MySql.Data.MySqlClient;

namespace CRUDDEMO.MovieBL
{
    public class BLMovies
    {
        /// <summary>
        /// For Getting List of Movies From Database
        /// </summary>
        /// <returns>
        /// List of Movie Objects
        /// </returns>
        public static List<Movie> listMovies()
        {
            // Creating List Of Movies
            List<Movie> movies = new List<Movie>();

            // Establishing New Connection to MySQlDatabse
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    con.Open();

                    // Creating MySQL Command
                    using (MySqlCommand cmd = new MySqlCommand("select * from mydatabase.movies", con))
                    {
                        // Executing MySQL Command
                        using (var reader = cmd.ExecuteReader())
                        {
                            // Reading From Result one by one
                            while (reader.Read())
                            {
                                //Adding Result to List
                                movies.Add(new Movie()
                                {
                                    MovieId = Convert.ToInt32(reader["movieID"]),
                                    MovieName = reader["movieName"].ToString(),
                                    MovieCountry = reader["movie_country"].ToString(),
                                    MovieLang = reader["movie_lang"].ToString(),
                                    DirectorName = reader["director_name"].ToString(),
                                    ReleaseYear = (reader["release_year"].ToString() != null && reader["release_year"].ToString() != "") ? Convert.ToInt32(reader["release_year"].ToString()) : 0
                                });
                            }
                        }
                    }
                }

                // Handling if Any Exception occurs
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    // Closing Connection
                    con.Close();
                }

            }
            return movies;
        }

        /// <summary>
        /// For Selecting Unique From Database
        /// </summary>
        /// <param name="id">
        /// int: For Uniquely Identifying Movie From DataBase
        /// </param>
        /// <returns>
        /// Return Single Movie Object
        /// </returns>
        public static Movie SelectMovieByID(int id)
        {

            Movie movie = new Movie();

            //Establishing new Connection to MySQL Database server
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    // CreATING nEW MYSQLCommand
                    using (MySqlCommand cmd = new MySqlCommand("select * from mydatabase.movies where movieID=" + id, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Initializing Object from returned result
                                movie.MovieId = id;
                                movie.MovieName = reader["movieName"].ToString();
                                movie.MovieCountry = reader["movie_country"].ToString();
                                movie.MovieLang = reader["movie_lang"].ToString();
                                movie.DirectorName = reader["director_name"].ToString();
                                movie.ReleaseYear = Convert.ToInt32(reader["release_year"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {   // Closing Connection
                    con.Close();
                }

            }
            return movie;
        }

        /// <summary>
        /// For Inserting And Updating Movie Data
        /// </summary>
        /// <param name="movie">
        /// Movie Object Contains new or old Movie Data For Saving into Databse
        /// </param>
        /// <returns>
        /// Message string for identifying operation is successfully done or not 
        /// </returns>
        public static string savingMovie(Movie movie)
        {
            // Validating Movie Name before inserting
            if (movie.MovieName != null)
            {
                // Establishing New Database Connection
                using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
                {

                    try
                    {
                        con.Open();

                        // Creating new MySQL Command
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = con;

                            // MovieId contains 0 if Inserting operation performs
                            if (movie.MovieId == 0)
                            {
                                // Creating Insert Query
                                cmd.CommandText = "INSERT INTO `mydatabase`.`movies` (`movieName`, `release_year`, `director_name`, `movie_lang`, `movie_country`) VALUES ('" + movie.MovieName + "', " + movie.ReleaseYear + ", '" + movie.DirectorName + "', '" + movie.MovieLang + "', '" + movie.MovieCountry + "');";

                            }

                            // Else Update operation Performs
                            else
                            {
                                // Creating Update Query
                                cmd.CommandText = "UPDATE `mydatabase`.`movies` SET `movieName` = '" + movie.MovieName + "', `release_year` = " + movie.ReleaseYear + ", `director_name` = '" + movie.MovieName + "', `movie_lang` = '" + movie.MovieLang + "', `movie_country` = '" + movie.MovieCountry + "' WHERE (`movieID` = '" + movie.MovieId + "');";

                            }

                            // Executing Query
                            int rowCount = cmd.ExecuteNonQuery();
                            if (rowCount > 0)
                            {
                                return "SUCCESS";
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        return ex.Message + movie.MovieId;
                    }
                    finally
                    {
                        con.Close();
                    }
                }

            }

            return "Something Wrong";
        }

        /// <summary>
        /// For Deleting particular Movie From Database
        /// </summary>
        /// <param name="id">
        /// in: id for iniquity identifying Movie from database
        /// </param>
        /// <returns>
        /// string that contains message 
        /// </returns>
        public static string deleteMovie(int id)
        {
            // Establishing connection
            using (MySqlConnection con = new MySqlConnection(DBConfig.ConnectionString))
            {

                try
                {
                    con.Open();

                    // Creating Delete Command
                    using (MySqlCommand cmd = new MySqlCommand("delete from mydatabase.movies where movieID=" + id, con))
                    {
                        // Execute Command
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
