using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B3.Models;
using B3.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace B3.Controllers
{
    public class HomeController : Controller
    {
        // We are using a PastryRepository in order to show some Pastries on Home Page
        private readonly IPastryRepository _pastryRepository;

        //Constructor
        public HomeController(IPastryRepository pastryRepository)
        {
            _pastryRepository = pastryRepository;     
        }

        

        //Action Method
        public IActionResult Index()
        {
            //View model that contains all Pastries
            var homeViewModel = new HomeViewModel
            {
                Pastries = _pastryRepository.AllPastries
            };

            return View(homeViewModel);
        }

       
    }
}
