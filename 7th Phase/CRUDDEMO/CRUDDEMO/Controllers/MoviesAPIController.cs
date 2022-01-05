using CRUDDEMO.Models;
using CRUDDEMO.MovieBL;
using CRUDDEMO.View_Model;
using System.Collections.Generic;
using System.Web.Http;


namespace CRUDDEMO.Controllers
{


    public class MoviesAPIController : ApiController
    {

        /// <summary>
        /// Get All Movies.
        /// </summary>
        /// <returns> return List Of Movie </returns>
        [Route("api/moviesapi/")]
        [Route("api/")]
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            Movies movies = new Movies()
            { movies = BLMovie.listMovies() };
            return movies.movies;
        }

        /// <summary>
        /// Get a Movie data base on its Id.
        /// </summary>
        /// <param name="movieID">
        /// int: Movie ID Pass for Identify Unique Movie Data.
        /// </param>
        /// <returns>
        /// return a Movie Model object with HttpStausCode.
        /// </returns>
        [Route("api/moviesapi/{movieID}")]
        [HttpGet]
        public IHttpActionResult GetMovieByID(int movieID)
        {
            Movie movie = BLMovie.SelectMovieByID(movieID);

            return movie.MovieId > 0 ? Ok(movie) : throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
        }

        /// <summary>
        /// For Inserting New Movie
        /// </summary>
        /// <param name="movie">
        /// movie is object of Movie Class contains Movie Details 
        /// Contains MovieId, MovieName, ReleaseYear, DirectorName 
        /// </param>
        /// <returns>
        /// Status code 200 OK if Successfully inserted new Data
        [Route("api/moviesapi/")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] Movie movie)
        {
            return BLMovie.savingMovie(movie) == "SUCCESS" ? Ok(200) : throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
        }

        /// <summary>
        /// For Updating Existing Movie
        /// </summary>
        /// /// <param name="movieId">
        /// movieid is used to uniquely identifying Movie Data 
        /// </param>
        /// <param name="movie">
        /// movie is object of Movie Class contains Movie Details 
        /// Contains MovieId, MovieName, ReleaseYear, DirectorName 
        /// </param>
        /// <returns>
        /// Status code 200 OK if Successfully updated new Data
        /// </returns>
        [Route("api/moviesapi/{movieId}")]
        [HttpPut]
        public IHttpActionResult Put(int movieId, [FromBody] Movie movie)
        {
            movie.MovieId = movieId;
            return BLMovie.savingMovie(movie) == "SUCCESS" ? Ok(200) : throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);

        }

        /// <summary>
        /// For Deleting a Particular Movie
        /// </summary>
        /// <param name="movieId">
        /// movieId is unique identity Movie Details</param>
        /// <returns>
        /// Status code 200 OK if Successfully Movie Data
        /// </returns>
        [Route("api/moviesapi/{movieId}")]
        [HttpDelete]
        public IHttpActionResult Delete(int movieId)
        {
            return BLMovie.deleteMovie(movieId) == "SUCCESS" ? Ok(200) : throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
        }
    }
}