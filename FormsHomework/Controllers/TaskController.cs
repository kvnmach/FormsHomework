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
            List<Task> presentTasks;
            presentTasks = (List<Task>) Session["tasks"] ?? new List<Task>();
            return View(presentTasks);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Task newTask)
        {
            if (ModelState.IsValid)
            {
                var presentTasks = (List<Task>) Session["tasks"];
                if (presentTasks == null)
                {
                    presentTasks = new List<Task>();
                }

                presentTasks.Add(newTask);

                Session["tasks"] = presentTasks;
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
        }
    }
}