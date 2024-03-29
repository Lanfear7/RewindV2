﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rolesDemoSSD.Data;
using rolesDemoSSD.Repositories;
using rolesDemoSSD.ViewModels;

namespace rolesDemoSSD.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<LibraryController> _logger;
        private readonly ApplicationDbContext _context;

        public LibraryController(ILogger<LibraryController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Library()
        {
            return View();
        }
        public IActionResult GetAllMovies()
        {
            ViewBag.TotalPrice = "4.99";
            MovieRepo movieRepo = new MovieRepo(_context);
            var query = movieRepo.GetAllMovies();
            return View(query);
        }

        public IActionResult GetMovieById(int id)
        {
            //_logger.LogInformation("movieid= " + typeof(MovieID));
            /* _logger.LogInformation("movieid= " + typeof(movie.MovieID));*/
            MovieRepo movieRepo = new MovieRepo(_context);
            MovieVM movieVM = movieRepo.GetMovieById(id);
            return View(movieVM);
        }


        [HttpGet]
        public ActionResult CreateMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMovie(MovieVM movieVM)
        {
            if (ModelState.IsValid)
            {
                MovieRepo movieRepo = new MovieRepo(_context);
                var success = movieRepo.CreateMovie(movieVM.MovieName, movieVM.PosterSource, movieVM.Genre, movieVM.Duration, movieVM.ReleaseDate, movieVM.Distributor);
                if (success)
                {
                    return RedirectToAction(nameof(GetAllMovies));
                }
            }
            ViewBag.Error = "An error occurred while creating this movie. Please try again.";
            return View();
        }

        [HttpGet]
        public ActionResult EditMovie()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult EditMovie(MovieVM movieVM)
        {
            MovieRepo movieRepo = new MovieRepo(_context);
            var success = movieRepo.EditMovieById(movieVM.MovieName, movieVM.MovieID, movieVM.PosterSource, movieVM.Genre, movieVM.Duration, movieVM.ReleaseDate, movieVM.Distributor);

            if (success)
            {
                return RedirectToAction(nameof(GetAllMovies));
            }
            ViewBag.Error = "An error occurred while editing this movie.";
            return View();
        }*/

        public ActionResult DeleteMovie(int id)
        {
            MovieRepo movieRepo = new MovieRepo(_context);
            Movie movieVM = movieRepo.DeleteMovieById(id);
            return RedirectToAction(nameof(GetAllMovies));
        }
        public IActionResult GetAllReviews()
        {
            ReviewRepo reviewRepo = new ReviewRepo(_context);
            var query = reviewRepo.GetAllReviews();
            return View(query);
        }
        [HttpGet]
        public ActionResult CreateReview()
        {
            return View(new ReviewVM {Email = User.Identity.Name });
        }

        [HttpPost]
        public ActionResult CreateReview(ReviewVM reviewVM)
        {
            if (ModelState.IsValid)
            {
                ReviewRepo reviewRepo = new ReviewRepo(_context);
                var success = reviewRepo.CreateReview(reviewVM.MovieID, reviewVM.ReviewTitle, reviewVM.ReviewContent, reviewVM.Rating);
                if (success)
                {
                    return RedirectToAction(nameof(GetAllMovies));
                }
            }
            ViewBag.Error = "An error occurred while creating this movie. Please try again.";
            return View();
        }
    }
}
