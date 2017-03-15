using EddyProject_Common.FilterAttribute;
using EddyProject_Dao.DataContext;
using EddyProject_Dao.Model_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EddyProject.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            //using (UserDAL userDal = new UserDAL())
            //{
            //    userDal.Database.Delete();
            //    userDal.Database.Create();
            //    for (int i = 0; i < 100; i++)
            //    {
            //        User user = new User() { Username = "JJ" + i, Password = "123" };
            //        userDal.users.Add(user);
            //        userDal.SaveChanges();
            //    }
            //}
            using(UserDAL userDAL = new UserDAL())
            {
            }
            return View();
        }

        [AdminFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}