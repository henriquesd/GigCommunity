using GigCommunity.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace GigCommunity.Persistence.EntityConfigurations
{
    public class UserNotificationConfiguration : EntityTypeConfiguration<UserNotification>
    {
        public UserNotificationConfiguration()
        {
            HasKey(un => new { un.UserId, un.NotificationId });

            HasRequired(un => un.User)
                .WithMany(un => un.UserNotifications)
                .WillCascadeOnDelete(false);
        }
    }
}