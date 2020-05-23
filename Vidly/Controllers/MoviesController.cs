using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movie = new Movie() {Id = 1, Name = "Movie name"};
            var customers = new List<Customer>
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        // //movies
        // public ActionResult Index(int? pageIndex, string sortBy)
        // {
        //     if(!pageIndex.HasValue)
        //     {
        //         pageIndex = 1;
        //
        //     }
        //     if(String.IsNullOrWhiteSpace(sortBy))
        //         sortBy = "sortByTitle";
        //     return Content(String.Format("pageIndex={0}&soreBy={1}", pageIndex, sortBy));
        // }
     
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ReleasedByYear(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}