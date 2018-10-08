using MovieBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using MovieBox.ViewModels;

namespace MovieBox.Controllers
{
    public class HomeController : Controller

    {
        private ApplicationDbContext db;

        public HomeController()
        {
            this.db = new ApplicationDbContext();
        }



        public ActionResult Index()
        {

            List<Movie> movie = db.Movies.ToList();
            var movies = db.Movies.Include(c => c.Category).FirstOrDefault();
            var viewmodel = new SortMovieViewModel
            {
                Movielist = movie,
                Category = db.Categories.ToList(),
                Movie = movies
            };

            return View(viewmodel);
        }

        public ActionResult Movies()
        {
            List<Movie> movie = db.Movies.ToList();
            var movies = db.Movies.Include(c => c.Category).FirstOrDefault();
            var viewmodel = new SortMovieViewModel
            {
                Movielist = movie,
                Category = db.Categories.ToList(),
                Movie = movies
            };

            return View(viewmodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}