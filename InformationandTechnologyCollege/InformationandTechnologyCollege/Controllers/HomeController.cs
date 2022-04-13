using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationandTechnologyCollege.Controllers
{
     public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return view for main page
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The College of West Anglia is focused on developing your skills and talents to prepare you for work or university";
            //return view for about page and create a message to be populated on the page
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //return view for contact page and create a message to be populated on the page

            return View();
        }
    }
}