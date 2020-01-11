using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Implements ICommentRepository
    public class CommentRepository : ICommentRepository
    {
        //We work with AppDbContext == Database
        private readonly AppDbContext _appDbContext;

        //Through Constructor Injection we get access to AppDbContext in CommentRepository
        public CommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        
        public IEnumerable<Pastry> AllPastries
        {
            // Reading out all the Pastry with Categories
            get
            {
                return _appDbContext.Pastries.Include(c => c.Category);
            }
        }
        
        //Getting all Comments
        public IEnumerable<Comment> GetAllComments()
        {
            return _appDbContext.Comments;
        }

        //Getting Comments by Pastry ID
        public IEnumerable<Comment> GetCommentByPastryId(int ProductId)
        {
            return _appDbContext.Comments.Where(c => c.PastryId == ProductId);
        }

        // Creating a new comment and saving it in the database
        public void CreateCommentAndAddToDatabase(Comment newcomment)
        {
            _appDbContext.Comments.Add(newcomment);
            _appDbContext.SaveChanges();
        }
    }
}
