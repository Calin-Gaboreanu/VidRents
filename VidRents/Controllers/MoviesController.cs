using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidRents.Models;


namespace VidRents.Controllers
{
    public class MoviesController : Controller
    {
        
        public ViewResult Index()
        {
            var movies = GetMovies();
            
            return View(movies);

        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
                {
                    new Movie {Id = 1, Name = "Wall-E"},
                    new Movie {Id = 2, Name = "Matrix"},
                    new Movie {Id = 3, Name = "InterStellar" }
                };
        }


    }
}