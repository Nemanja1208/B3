using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    public class Pastry
    {
        //Pastry Properties
        public int PastryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int CategoryId { get; set; }

        //Pastry has a category , so we create a category class
        public PastryCategory Category { get; set; }
    }
}
