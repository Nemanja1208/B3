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
    //Controller is the first place we benefit from the Dependency Injection System 
    //Here we need access to our repositories/data (data controlled by the repositories)
    //Most important is the ACTION Method that is handling the incoming requests
    public class PastryController : Controller
    {
        //Access to Data controlled by repositories / interface
        private readonly IPastryRepository repositoryofpastries;
        private readonly IPastryCategoryRepository repositoryofcategories;

        //Constructor where we pass/are injected Repositories by the Dependency Injection System

        public PastryController(IPastryRepository repositoryofpastriesToSet, IPastryCategoryRepository repositoryofcategoriesToSet)
        {
            repositoryofpastries = repositoryofpastriesToSet;
            repositoryofcategories = repositoryofcategoriesToSet;

            //New Comment
            

            //Now we have access to our Model Classes in the Controller
        }

        //Action methods that handles requests and gives back a View

        //Action ListOfProducts that returns a View of All the Pastries in the Mock Pastry Repository
        //View that we can acces through root/Pastry/ListOfProducts or just /list
        //Instead of ViewBag we use ViewModels
        public ViewResult ListOfProducts()
        {
            PastryListViewModel pastryListViewModel = new PastryListViewModel();
            pastryListViewModel.Pastries = repositoryofpastries.AllPastries;
            return View(pastryListViewModel);
        }

        //View that we can acces when we click on a pastry 
        public IActionResult Details(int id)
        { 
            var pastry = repositoryofpastries.GetPastryById(id);
            if (pastry == null)
                return NotFound();
            return View(pastry);
        }

        [HttpGet]
        public IActionResult Comment()
        {
            return View(new MainComment());
        }

        //Comments
        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel comviewmodel)
        {
            if (ModelState.IsValid) { }
            
            //If ID is bigger than 0 it is a subcomment, if it is 0 it is a main comment
            var pastry = repositoryofpastries.GetPastryById(comviewmodel.PastryId);
            if (comviewmodel.MainCommentId == 0)
            {
                pastry.MainComments = pastry.MainComments ?? new List<MainComment>();

                pastry.MainComments.Add(new MainComment
                {
                    Message = comviewmodel.Message,
                    Created = DateTime.Now,

                });

                //Updating Pastry in database with comments
                repositoryofpastries.UpdatePastry(pastry);
                return RedirectToAction("Details", new { id = comviewmodel.PastryId });

            }
            else
            {
                var comment = new SubComment
                {
                    MainCommentId = comviewmodel.MainCommentId,
                    Message = comviewmodel.Message,
                    Created = DateTime.Now,
                };
            }
            await repositoryofpastries.SaveChangesAsync();
            return View();
        }
    }
}
