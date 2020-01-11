using B3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.ViewModels
{
    //View Model that has Pastries and Comments
    public class PastryDetailViewModel
    {
        public Pastry PastryDetails { get; set; }

        public List<Comment> Comments { get; set; }
        
    }
}
