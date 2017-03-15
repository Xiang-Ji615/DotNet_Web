using EddyProject_Bo.UserBo;
using EddyProject_Bo.ViewModel_Curd;
using EddyProject_Common.CommonUtil;
using EddyProject_Dao.Model_Login;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EddyProject.Controllers
{
    public class CurdController : Controller
    {
        IUserBo userBo = UserBoImp.getInstance();
        // GET: Curd
        public ActionResult Index()
        {
            CurdViewModel curdViewModel = new CurdViewModel();
            curdViewModel.UserList = userBo.listUser();
            return View(curdViewModel);
        }

        public ActionResult Paged(int page = 1, int pageSize = 10, String username = "", String password = "")
        {
            var actionURL = this.Url.Action("Paged");
            CurdViewModel curdViewModel = new CurdViewModel();
            
            ViewBag.showPager = true;
            if(!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
            {
                ViewBag.showPager = false;
                curdViewModel.UserList = userBo.listUser(page, 10000, username, password);
            }
            else
            {
                curdViewModel.UserList = userBo.listUser(page, pageSize, username, password);
            }
            ViewBag.username = username;
            ViewBag.password = password;
            curdViewModel.Pager = new Pager(page, pageSize, userBo.getUserSize(username, password));
            IPagerUtil pagerUtil = PagerUtil.getInstance();
            curdViewModel.PagerObject = pagerUtil.getPagerObject(curdViewModel.Pager, 5, actionURL + "?pageSize="+pageSize);
            return View("Index", curdViewModel);
        }

        public ActionResult Edit(String name)
        {
            ViewBag.name = name;
            return View();
        }

        public ActionResult Search(User user)
        {
            return View();
        }
    }
}