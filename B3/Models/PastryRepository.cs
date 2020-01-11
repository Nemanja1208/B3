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

        //Getting Pastry by Pastry ID 
        public Pastry GetPastryById(int PastryId)
        {
            return _appDbContext.Pastries.FirstOrDefault(p => p.PastryId == PastryId);
        }
    }
}
