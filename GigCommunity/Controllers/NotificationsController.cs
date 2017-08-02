using GigCommunity.Core.Persistence;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigCommunity.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Authorize]
        public ViewResult Index()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _unitOfWork.Notifications.GetAllNotificationsFor(userId);

            return View(notifications);
        }
    }
}