using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorization.Controllers.Admin
{
    public class AppManagementController : Controller
    {
        // GET: AppManagement
        public ActionResult Index()
        {
            return View();
        }
    }
}