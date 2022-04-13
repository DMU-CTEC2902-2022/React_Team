using InformationandTechnologyCollege.Services.Business;
using InformationandTechnologyCollege.Services.Data;
using InformationandTechnologyCollege.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationandTechnologyCollege.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login( clsUserModel UserModel)
        {
            //return "Results : Username = " + UserModel.UserName + "PW = " + UserModel.Password;

            clsSecurityService securityService = new clsSecurityService();
            Boolean success = securityService.Authenticate(UserModel);

            if (success)
            {
                return View("LoginSuccess", UserModel);
            }
            else
            {
                return View("LoginFailure");
            }
        }


     }
}