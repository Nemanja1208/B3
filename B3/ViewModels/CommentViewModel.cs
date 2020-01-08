using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B3.ViewModels
{
    public class CommentViewModel
    {
        //We want to know what Pastry we commented on
        [Required]
        public int PastryId { get; set; }
        //We want to know what is the message of the comment
        [Required]
        public string Message { get; set; }
        //We want to know what the Main Comment is
        [Required]
        public int MainCommentId { get; set; }
    }
}
