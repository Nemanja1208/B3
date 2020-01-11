using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B3.Models;
using B3.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ICommentRepository repositoryofcomments;
        private readonly AppDbContext database;

        //Constructor where we pass/are injected Repositories by the Dependency Injection System

        public PastryController(IPastryRepository repositoryofpastriesToSet, IPastryCategoryRepository repositoryofcategoriesToSet,ICommentRepository repositoryofcommentsToSet, AppDbContext appDbContext)
        {
            repositoryofpastries = repositoryofpastriesToSet;
            repositoryofcategories = repositoryofcategoriesToSet;
            repositoryofcomments = repositoryofcommentsToSet;
            database = appDbContext;

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
            //ViewModel that we use in order to show Pastry with Comments
            PastryDetailViewModel viewmodelfordetails = new PastryDetailViewModel();
            //In the PastryDetailViewModel we have All the Pasteries with properties and All the Comments in a List
            viewmodelfordetails.Comments = new List<Comment>();
            //In order to show the comments we need to know which Product where are showing comments for and setting the ViewModel for that Pastry
            Pastry pastry = repositoryofpastries.GetPastryById(id);
            viewmodelfordetails.PastryDetails = pastry;
            //Now we can access the Comments for that specific Pastry so we create a list that we are going to pass on to the ViewModel
            IEnumerable<Comment> ListOfComments;
            //Gets the Comments by the Pastry ID
            ListOfComments = repositoryofcomments.GetCommentByPastryId(id);
            //And passes on to the ViewModel List
            viewmodelfordetails.Comments = ListOfComments.ToList();
            //Returns a View Model for View Detail
            return View(viewmodelfordetails);
        
        }

        [HttpGet]
        public IActionResult Comment()
        {
            return View(new Comment());
        }

        //Comments and Rating with Authorization
        [Authorize]
        [HttpPost]
        public IActionResult Comment(int id, string text, float rating)
        {
            //If the message text is empty just reload
            if (text == "")
            {
                return RedirectToAction("Details", new { id });
            }
            //else we create a new Comment
            Comment comment = new Comment();
            //CommentId is GUID
            comment.CommentId = Guid.NewGuid().ToString();
            //PastryID of the comment is the Id from the request
            comment.PastryId = id;
            //Message of the Comment is the input type text
            comment.CommentMessage= text;
            //Rating of the Pastry 
            comment.Rating += rating;
            //Finaly we Add and Save/Update the database with the new comment
            repositoryofcomments.CreateCommentAndAddToDatabase(comment);
            //And reload the page with the new comment and rating added
            return RedirectToAction("Details", new { id });
        }   
    }
}
