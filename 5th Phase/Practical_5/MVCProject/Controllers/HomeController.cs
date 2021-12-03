using MVCProject.Models;
using MVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        MyDBContext _context;
        public HomeController()
        {
            _context = new MyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var viewModel = new MoviesViewModel
            {
                Movies = _context.Movies.ToList()
            };

            return View(viewModel);
        }

        public ActionResult MovieForm()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == Id);
            if(movie == null)
            {
                return HttpNotFound();
            }

            
            return View("MovieForm",movie);
        }

        [HttpPost]
        public ActionResult Save(Movies movie)
        {
            
            _context.Movies.Add(movie);
            _context.SaveChanges();
            
            return RedirectToAction("Index","Home");
        }
    }
}