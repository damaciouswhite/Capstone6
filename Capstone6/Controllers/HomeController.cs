﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone6.Models; //added model to home controller cc

namespace Capstone6.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UserTasksView()
        {
            //1. get database
            Capstone6Entities ormList = new Capstone6Entities();

            //2. Get user id
            User selectUser = ormList.Users.Find(1);

            //3.load items into viewbag matching userid

            ViewBag.theUserTasks = ormList.Tasks.Where(x => x.userID == selectUser.userID).ToList();

            //3.return view
            return View();
        }

        //for testing purposes
        public ActionResult AllUserTasksView()
        {
            //1. get database
            Capstone6Entities ormListTask = new Capstone6Entities();

            //3.load items into viewbag matching userid

            ViewBag.AllTasks = ormListTask.Tasks.ToList();

            //ViewBag.theUsersTasks = ormList.Tasks.Where(u => u.userID == getTasks.userID).ToString();

            //3.return view
            return View();
        }
    }
}