using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Creating a Mock Comment Repository that implements ICommentRepository for purposes of the XUnit Test
    public class MockCommentRepository : ICommentRepository
    {


        //Implementing hard-coded Pastry data
        public IEnumerable<Comment> AllComments =>
            new List<Comment>
            {
                new Comment {PastryId = 1,CommentId = "1", CommentMessage = "Delicious", Created = DateTime.Now, Rating = 10 },
                new Comment {PastryId = 2,CommentId = "1", CommentMessage = "Beautiful", Created = DateTime.Now, Rating = 9 },
                new Comment {PastryId = 3,CommentId = "1", CommentMessage = "Perfekt", Created = DateTime.Now, Rating = 8 }

            };


        public void CreateCommentAndAddToDatabase(Comment newcomment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAllComments()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentByPastryId(int ID)
        {
            return AllComments.Where((c => c.PastryId == ID));
        }

        //Get all Pastries
         public IEnumerable<Pastry> AllPastries { get; }


        //Small implementation of GetPastryById
        public Pastry GetPastryById(int pastryId)
        {
            return AllPastries.FirstOrDefault(p => p.PastryId == pastryId);
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
