using GigCommunity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigCommunity.Core.Repositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string followerId, string followeeId);
        void Add(Following following);
        void Remove(Following following);
    }
}
