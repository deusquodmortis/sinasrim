using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SinasRim.Models;

namespace SinasRim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(mail model)
        {
            mail a = new mail();
            string z = model.name +" "+ model.surname;
            string x = model.mailfrom + " " + model.icerik;
            a.mailGönderme(x, model.mailfrom,z);

            return View();
        }
        public ActionResult Catalog()
        {
            ViewBag.Message = "Your catalog page.";

            return View();
        }
        public ActionResult Ref()
        {
            ViewBag.Message = "Your ref page.";

            return View();
        }
        public void mailyolla(string c, string b)
        {
            
        }
    }
}