using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    public class SubComment : Comment
    {
        public int MainCommentId { get; set; }
    }
}
