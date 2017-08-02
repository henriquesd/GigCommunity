using GigCommunity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigCommunity.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGig(int gigId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(String artistiId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId, string searchTerm = null);
        void Add(Gig gig);
        IEnumerable<Gig> GetUpcomingGigs(string searchTerm = null);
    }
}
