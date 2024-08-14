using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movies.Models;
using Movies.Repository;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieRepository<Movies> _movieRepo = null;

        public MoviesController()
        {
            _movieRepo = new MovieRepository<Movies>();
        }

        public ActionResult Index()
        {
            var movies = _movieRepo.GetAll();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepo.Insert(movie);
                _movieRepo.Save();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = _movieRepo.GetById(id);
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movies movie)
        {
            if (ModelState.IsValid)
            {
                _movieRepo.Update(movie);
                _movieRepo.Save();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Details(int id)
        {
            var movie = _movieRepo.GetById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        public ActionResult Delete(int id)
        {
            var movie = _movieRepo.GetById(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var movie = _movieRepo.GetById(id);
            _movieRepo.Delete(id);
            _movieRepo.Save();
            return RedirectToAction("Index");
        }
    }
}