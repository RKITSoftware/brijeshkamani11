using HttpVerbsDemo.BLClasses;
using HttpVerbsDemo.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace HttpVerbsDemo.Controllers
{
    [RoutePrefix("api/movies")]
    public class MoviesController : ApiController
    {
        //Creating object of class BLMovies
        BLMovies objMovies = new BLMovies();


        /// <summary>
        /// For getting All Movies
        /// </summary>
        /// <returns>
        /// List of Movie Objects
        /// </returns>
        [Route("")]
        [HttpGet]
        public List<Movie> Get()
        {
            return objMovies.GetMovies();
        }

        /// <summary>
        /// For Getting Single Movie Object By Its ID 
        /// </summary>
        /// <param name="movieId">
        /// movieId for uniquely identifying Movie From List</param>
        /// <returns>
        /// Single Movie Object if Found
        /// </returns>
        [Route("{movieId}")]
        [HttpGet]
        public Movie Get(int movieId)
        {
            return objMovies.GetMovieByID(movieId);
        }

        /// <summary>
        /// For Adding New Movie
        /// </summary>
        /// <param name="movie">
        /// movie contains new values for inserting into list
        /// </param>
        /// <returns>
        /// Status Code 200 if Inserted Successfully
        /// </returns>
        [Route("")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] Movie movie)
        {
            objMovies.AddMovie(movie);
            return Ok(200);
        }

        /// <summary>
        /// Update Existing Movie Data Based on its ID From List
        /// </summary>
        /// <param name="movieId">
        /// movieId for uniquely identify Movie From List</param>
        /// <param name="movie">
        /// movie contains new data for updating into list
        /// </param>
        /// <returns>
        /// Status Code 200 if Updated Successfully
        /// </returns>
        [Route("{movieId}")]
        [HttpPut]
        public IHttpActionResult Put(int movieId, [FromBody] Movie movie)
        {
            objMovies.UpdateMovie(movieId, movie);
            return Ok(200);
        }

        /// <summary>
        /// for Delete Existing Movie Based On its Id
        /// </summary>
        /// <param name="movieId">
        /// movieId for uniquely identity movie from list</param>
        /// <returns>
        /// Status Code 200 if Deleted Successfully
        /// </returns>
        [Route("{movieId}")]
        [HttpDelete]
        public IHttpActionResult Delete(int movieId)
        {
            objMovies.RemoveMovie(movieId);
            return Ok(200);
        }
    }
}
