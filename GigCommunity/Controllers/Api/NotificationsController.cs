using AutoMapper;
using GigCommunity.Core.Dtos;
using GigCommunity.Core.Models;
using GigCommunity.Core.Persistence;
using GigCommunity.Persistence;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using WebGrease.Css.Extensions;

namespace GigCommunity.Controllers.Api
{
    [Authorize]
    public class NotificationsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<NotificationDto> GetNewNotifications()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _unitOfWork.Notifications.GetNewNotificationsFor(userId);

            return notifications.Select(Mapper.Map<Notification, NotificationDto>);
        }

        [HttpPost]
        public IHttpActionResult MarkAsRead()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _unitOfWork.UserNotifications.GetUserNotificationsFor(userId);

            notifications.ForEach(n => n.Read());

            _unitOfWork.Complete();

            return Ok();
        }
    }
}
