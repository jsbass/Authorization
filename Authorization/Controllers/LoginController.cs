using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Authorization.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            if (HttpContext.Request.IsAuthenticated)
            {
                return FormsAuthentication.Decrypt(HttpContext.Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name);
            }
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<ActionResult> Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }

        public async Task<ActionResult> Logout()
        {
            return View();
        }
    }
}