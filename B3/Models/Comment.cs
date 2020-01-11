using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    public class Comment
    {
        //Comment ID need to be string in order for GUID to work
        public string CommentId { get; set; }
        //Text Message of the Comment
        public string CommentMessage { get; set; }
        //Id of the Pastry Comment is on
        public int PastryId { get; set; }
        //DateTime.Now The time Comment is created
        public DateTime Created { get; set; }
        //Comments will also have a property for Ratings
        public float Rating { get; set; }
    }
}
