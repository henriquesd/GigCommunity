using GigCommunity.Core.Persistence;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigCommunity.Controllers
{
    public class FolloweesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FolloweesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var artists = _unitOfWork.Users.GetArtistsFollowedBy(userId);

            return View(artists);
        }
    }
}