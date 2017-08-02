using GigCommunity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigCommunity.Core.Repositories
{
    public interface INotificationRepository
    {
        IEnumerable<Notification> GetNewNotificationsFor(string userId);
        IEnumerable<Notification> GetAllNotificationsFor(string userId);
    }
}
