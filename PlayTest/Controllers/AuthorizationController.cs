using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlayTest.Models;
using PlayTest.Structure;

namespace PlayTest.Controllers
{
    public class AuthorizationController : Controller
    {
        public ActionResult Index(UserDTO potentialUser)
        {
            return View(potentialUser);
        }

        [HttpPost]
        public ActionResult Sign(string login, string password)
        {
            var potentialUser = new UserDTO
            {
                Login = login,
                Password = password
            };
            if (UserRepository.CheckUser(potentialUser))
            {
                potentialUser.StateAuth = true;
                return RedirectToAction(nameof(MapController.Init), "Map", potentialUser);
            }
            else
            {
                return RedirectToAction(nameof(AuthorizationController.Index), potentialUser);
            }
        }
    }
}