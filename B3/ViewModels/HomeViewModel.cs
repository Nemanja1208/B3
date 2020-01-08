using B3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.ViewModels
{
    //View Model that has All Pastries
    public class HomeViewModel
    {
        public IEnumerable<Pastry> Pastries { get; set; }
    }
}
