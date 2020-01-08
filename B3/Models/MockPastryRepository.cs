using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Creating a Mock Pastry Repository that implements IPastryRepository
    public class MockPastryRepository : IPastryRepository
    {
        //Using a hard-coded CategoryRepository instance
        private readonly IPastryCategoryRepository caterogiesofpastry = new MockPastryCategoryRepository();

        //Implementing hard-coded Pastry data
        public IEnumerable<Pastry> AllPastries =>
            new List<Pastry>
            {
                new Pastry {PastryId = 1, Name="Corn flour Bread", Description="Bread made of special full corn flour from Germany", Category= caterogiesofpastry.AllPastryCategories.ToList()[0] , CategoryId=1, ImageThumbnailUrl="https://www.kissunclinics.com/wp-content/uploads/2019/08/Bread.jpg"},
                new Pastry {PastryId = 2, Name="Croissant", Description="Croissant made by the oldest recipe in France", Category= caterogiesofpastry.AllPastryCategories.ToList()[1] , CategoryId=2, ImageThumbnailUrl="http://open.imagebank.lantmannen.com/Lantmannen%20Unibake/pimimage/3455.jpg"},
                new Pastry {PastryId = 3, Name="Cherry Pie", Description="Taste so good, makes a grown man cry, Sweet Cherry Pie", Category= caterogiesofpastry.AllPastryCategories.ToList()[2] , CategoryId=3, ImageThumbnailUrl="https://static.mathem.se/shared/images/recipes/doublelarge/15-plock_leila_korsbarspaj_jpg.jpeg"}
            };

        //Get all Pastries
        public IEnumerable<Pastry> AllPastriez { get; }

        public void AddSubComment(MainComment SubComment)
        {
            throw new NotImplementedException();
        }

        public void AddSubComment(SubComment SubComment)
        {
            throw new NotImplementedException();
        }

        //Small implementation of GetPastryById
        public Pastry GetPastryById(int pastryId)
        {
            return AllPastriez.FirstOrDefault(p => p.PastryId == pastryId);
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdatePastry(Pastry pastry)
        {
            throw new NotImplementedException();
        }
    }
}
