
using System.Collections.Generic;
using System.Web.Mvc;
using CRUDDEMO.Models;
using CRUDDEMO.MovieBL;
using CRUDDEMO.View_Model;

namespace CRUDDEMO.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            
            Movies movies = new Movies()
            { movies = BLMovie.listMovies() };
            return View(movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movies/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                // TODO: Add insert logic here
                string message = BLMovie.insertMovie(movie);
                if (message == "SUCCESS")
                    return RedirectToAction("Index");
                else
                    return Content("Error: " + message);
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            Movie movie = BLMovie.SelectMovieByID(id);
            return View("Add",movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            string message = BLMovie.deleteMovie(id);
            if (message == "SUCCESS")
                return RedirectToAction("Index");
            else
                return Content("Error: " + message);
        }

        // POST: Movies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
