using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormsHomework.Models;

namespace FormsHomework.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            List<Task> tasks;
            tasks = (List<Task>) Session["tasks"] ?? new List<Task>();
            return View(tasks);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task newTask)
        {
            
        }
    }
}