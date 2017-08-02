using GigCommunity.Core.Models;
using GigCommunity.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigCommunity.Persistence.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genres.ToList();
        }
    }
}