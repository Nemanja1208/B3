using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //We are using the Mock Pastry Category Repository that implements IPastryCategoryRepository
    public class MockPastryCategoryRepository : IPastryCategoryRepository
    {
        //Here we are using hard-coded Pastry Categories
        public IEnumerable<PastryCategory> AllPastryCategories =>
            new List<PastryCategory>
            {
                new PastryCategory {CategoryId=1, CategoryName="Bread", Description="All possible sorts of bread with different kind of flour"},
                new PastryCategory {CategoryId=2, CategoryName="PuffPastry", Description="All possible sorts of puff pastry with different kind of flour, for example croissants..."},
                new PastryCategory {CategoryId=3, CategoryName="Pies", Description="All possible sorts of pies with different kind of flavours"}
            };

    }
}
