using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Implements the IPastryCategoryRepository
    public class PastryCategoryRepository : IPastryCategoryRepository
    {
        //Working with AppDbContext
        private readonly AppDbContext _appDbContext;
        public PastryCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Getting All Categories
        public IEnumerable<PastryCategory> AllPastryCategories => _appDbContext.Categories;
    }
}
