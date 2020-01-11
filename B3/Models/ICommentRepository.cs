using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Interface (allows us to work with data) with properties of a class
    public interface ICommentRepository
    {
        //List of all the pasteries
        IEnumerable<Pastry> AllPastries { get; }
        
        //Getting all the comment from the database
        IEnumerable<Comment> GetAllComments();

        //Getting the comments by Pastry / PastryId
        IEnumerable<Comment> GetCommentByPastryId(int ID);

        //Creating a Comment and saving it in the database
        void CreateCommentAndAddToDatabase(Comment newcomment);
    }
}
