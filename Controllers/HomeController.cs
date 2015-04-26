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
        public JsonResult Index()
        {
            //JarvisBuzzDB.Login.Add(new LoginModel() { UserName = "SP", Password = "sp", Role = UserRole.User });
            //JarvisBuzzDB.SaveChanges();
            JarvisBuzzDB.Login.ToList();
            return Json(JarvisBuzzDB.Login.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
