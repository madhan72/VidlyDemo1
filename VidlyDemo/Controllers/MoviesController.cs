using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyDemo.Models;
using VidlyDemo.ViewModel;

namespace VidlyDemo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movies { Name = "Movie name" };

            var customers = new List<Customer>
            {
                new Customer { Name="abc 1"},
                new Customer { Name="mkas 2"},
                new Customer { Name="abc 3"},
                new Customer { Name="abc 4"},
                new Customer { Name="abc 5"}
            };

            var viewmodel = new VM_RandomMovie
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewmodel);

            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id :" + Id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movie = new List<Movies>
            {
                new Movies { Name="Abcd fkaj"},
                new Movies { Name="Xyz moadj"}
            };

            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return View(movie);
        }

        //Attribute Routing
        [Route("movies/released/{year:regex(\\d{4}):range(2010, 2020)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}