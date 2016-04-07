using FormsHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsHomework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            List<Task> task = new List<Task>()
            {
                new Task(1, "Kevin Mach", "Hello", true),
                new Task(2, "Kevin Mach", "World", false),
            };
            return View(task);
        }

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