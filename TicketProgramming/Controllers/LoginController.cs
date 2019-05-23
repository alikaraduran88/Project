using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketProgramming.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(String Username, string password)
        {
            return View();
        }
    }
}