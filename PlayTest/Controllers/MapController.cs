using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PlayTest.Controllers
{
    public class MapController : Controller
    {
        public ActionResult Init()
        {
            return View();
        }
    }
}