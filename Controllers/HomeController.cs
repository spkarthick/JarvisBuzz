using JarvisBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JarvisBuzz.Controllers
{
    public class HomeController : Controller
    {
        JarvisBuzzContext JarvisBuzzDB = new JarvisBuzzContext();
        public ActionResult Index()
        {
            //JarvisBuzzDB.Login.Add(new LoginModel() { UserName = "SP", Password = "sp", Role = UserRole.User });
            //JarvisBuzzDB.SaveChanges();
            return View();
        }
    }
}
