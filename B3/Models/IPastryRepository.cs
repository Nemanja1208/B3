using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Models
{
    //Interface (allows us to work with data) with properties where we define All Pies and a Method called Get Pastry by ID where we pass an ID and it returns a Pie
    public interface IPastryRepository
    {
        IEnumerable<Pastry> AllPastries { get; }
        Pastry GetPastryById(int PastryId);
        void UpdatePastry(Pastry pastry);
        void AddSubComment(SubComment comment);
        Task<bool> SaveChangesAsync();
    }
}
