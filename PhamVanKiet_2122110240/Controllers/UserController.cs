using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhamVanKiet_2122110240.Controllers
{
    public class UserController : Controller
    {
        // GET: UserLogin
        public ActionResult UserLogin()
        {
            return View();
        }
        public ActionResult UserRegister()
        {
            return View();
        }

    }
}