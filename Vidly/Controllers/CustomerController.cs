using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer() {Id = 1, Name = "Marcin Chorzepa"},
                new Customer() {Id = 2, Name = "Stefan Patefan"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers
            };
          
            return View(viewModel);
        }

        //GET: Customer/Details/{id}
        public ActionResult Details(int Id)
        {
            
            var customers = new List<Customer>
            {
                new Customer() {Id = 1, Name = "Marcin Chorzepa"},
                new Customer() {Id = 2, Name = "Stefan Patefan"}
            };
            var customer = customers.Find(x=>x.Id==@Id);

            return View(customer);
        }

    }

}