using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Implements IPastryRepository
    public class PastryRepository : IPastryRepository
    {
        //We work with AppDbContext == Database
        private readonly AppDbContext _appDbContext;

        //Through Constructor Injection we get access to AppDbContext in PastryRepository
        public PastryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pastry> AllPastries
        {
            // Reading out all the Pastry with Categories
            get
            {
                return _appDbContext.Pastries.Include(c => c.Category);
            }
        }

        //Getting Pie by ID and including Main and SubComments
        public Pastry GetPastryById(int PastryId)
        {
            return _appDbContext.Pastries.Include(p => p.MainComments).ThenInclude(mc => mc.SubComments).FirstOrDefault(p => p.PastryId == PastryId);
        }

        //Updating a Pastry with Comments
        public void UpdatePastry(Pastry pastry)
        {
            _appDbContext.Pastries.Update(pastry);
        }

        //Adding Comment
        public void AddSubComment(SubComment comment)
        {
            _appDbContext.SubComments.Add(comment);
        }

        //ASYNC that commits changes to database
        public async Task<bool> SaveChangesAsync()
        {
            if(await _appDbContext.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
