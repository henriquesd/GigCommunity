using GigCommunity.Core.Models;
using GigCommunity.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GigCommunity.Persistence.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly IApplicationDbContext _context;

        public NotificationRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Notification> GetNewNotificationsFor(string userId)
        {
            return _context.UserNotifications
                .Where(un => un.UserId == userId && !un.IsRead)
                .Select(un => un.Notification)
                .Include(n => n.Gig.Artist)
                .ToList();
        }

        public IEnumerable<Notification> GetAllNotificationsFor(string userId)
        {
            return _context.UserNotifications
                .Where(un => un.UserId == userId)
                .Select(un => un.Notification)
                .Include(n => n.Gig.Artist)
                .OrderByDescending(n => n.Id)
                .ToList();
        }
    }
}