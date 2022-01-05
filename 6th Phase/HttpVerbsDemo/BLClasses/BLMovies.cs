using HttpVerbsDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace HttpVerbsDemo.BLClasses
{
    public class BLMovies
    {
        #region private Data

        // List of Movies For Storing RunTime Data
        private List<Movie> movies = new List<Movie>();

        #endregion private Data

        #region Public Methods

        /// <summary>
        /// Constructor For Initialize Few Movies At Runtime
        /// </summary>
        public BLMovies()
        {
            this.movies.Add(new Movie { DirectorName = "RajaMoli", MovieCountry = "India", MovieId = 1, MovieLang = "Telugu", MovieName = "BahuBali", ReleaseYear = 2015 });
            this.movies.Add(new Movie { DirectorName = "Jon Watts", MovieCountry = "USA", MovieId = 2, MovieLang = "English", MovieName = "Spider-Man: No Way Home", ReleaseYear = 2021 });
            this.movies.Add(new Movie { DirectorName = "Makoto Shinkai", MovieCountry = "Japan", MovieId = 3, MovieLang = "Japanese", MovieName = "Your Name", ReleaseYear = 2016 });
        }

        /// <summary>
        /// For Getting List Of Movies
        /// </summary>
        /// <returns>
        /// List of Movies
        /// </returns>
        public List<Movie> GetMovies()
        {
            return movies;
        }

        /// <summary>
        /// for Getting a single Selected Value by its ID 
        /// </summary>
        /// <param name="movieID">
        /// movieID is unique identity number for each Movies</param>
        /// <returns>
        /// return Single Movie Object if Found
        /// </returns>
        public Movie GetMovieByID(int movieID)
        {
            return movies.Where(m => m.MovieId == movieID).FirstOrDefault();
        }

        /// <summary>
        /// Insert New Movie
        /// </summary>
        /// <param name="movie">
        /// Contains values for new Movie 
        /// </param>
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        /// <summary>
        /// Update Existing Movie From List
        /// </summary>
        /// <param name="movieIdid">
        /// movieId uniquely identity Movie Form List</param>
        /// <param name="movie">
        /// movie Contains new Data for Existing  Movie 
        /// </param>
        public void UpdateMovie(int movieId, Movie movie)
        {
            movies[movieId] = movie;
        }


        /// <summary>
        /// Removes particular Movie by Its ID
        /// </summary>
        /// <param name="movieId">
        /// movieId for uniquely identity Movie From List
        /// </param>
        public void RemoveMovie(int movieId)
        {
            movies.Remove(movies.Where(m => m.MovieId == movieId).FirstOrDefault());
        }

        #endregion Public Methods
    }
}