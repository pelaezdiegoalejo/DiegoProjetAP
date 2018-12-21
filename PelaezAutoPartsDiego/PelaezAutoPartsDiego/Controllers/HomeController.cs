using PelaezAutoPartsDiego.Models;
using PelaezAutoPartsDiego.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PelaezAutoPartsDiego.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignOut()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult SignOut(Usager model)
        {
            Usager Usager = Validation.ValidationUsager(model);
            if (Usager != null)
                return View();
            else
                ViewBag.Message1 = "Usager ou mot de passe incorret";
                return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}