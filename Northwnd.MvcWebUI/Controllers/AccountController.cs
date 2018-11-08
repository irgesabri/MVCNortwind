using Northwnd.Bll.Concrete;
using Northwnd.Entities;
using Northwnd.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Northwnd.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        AuthenticationManager _authenticationManager;
        public AccountController(AuthenticationManager authenticationManager)
        {
            _authenticationManager = authenticationManager;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View(new User());
        }
        [HttpPost]
        public ActionResult Login(User user,string returnurl)
        {
            if (ModelState.IsValid)
            {
                User validateuser = _authenticationManager.Authenticate(user);
                if (validateuser!=null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return Redirect(returnurl);
                }
            }
            else
            {
                ModelState.AddModelError("Hata", "Kullanıcı adı veya şifresi hatalı");
            }
            return View();
        }
    }
}