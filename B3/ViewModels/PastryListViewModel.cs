using B3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.ViewModels
{
    //View Model that shows All Pastries, contains data for View
    public class PastryListViewModel
    {
        public IEnumerable<Pastry> Pastries { get; set; }
    }
}
