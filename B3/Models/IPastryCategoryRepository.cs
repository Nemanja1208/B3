using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Interface that allows us to work with our Categories with property AllPastryCategories
    public interface IPastryCategoryRepository
    {
        //Returns all Pastry Categories we currently have
        IEnumerable<PastryCategory> AllPastryCategories { get; }
    }
}
