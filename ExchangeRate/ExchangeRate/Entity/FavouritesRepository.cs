using ExchangeRate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate.Entity
{
    public class FavouritesRepository
    {
        private AppDbContext _context;

        public FavouritesRepository() 
        {
            _context = new AppDbContext();
        }

        public IQueryable<Favourite> GetAllFavourites()
        {
            return _context.Favourites.AsNoTracking();
        }

        public Favourite GetFavourite(string id)
        {
            return _context.Favourites.AsNoTracking().FirstOrDefault(x => x.favLetterCode == id);
        }

        public void DeleteFav(string id)
        {
            _context.Favourites.Remove(new Favourite { favLetterCode = id });
            _context.SaveChanges();
        }

        public void AddFav(string id)
        {
            Favourite newFav = new Favourite() { favLetterCode = id };
            _context.Favourites.Add(newFav);
            _context.SaveChanges();
            _context.Entry(newFav).State = EntityState.Detached;
        }
    }
}
