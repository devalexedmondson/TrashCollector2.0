using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector2._0.Models;

namespace TrashCollector2._0.Controllers
{
    public class CollectorController : Controller
    {
        ApplicationDbContext db;

        public CollectorController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Collector
        public ActionResult CollectorIndex()
        {
            return View();
        }

        //GET: COLLECTOR/VIEWDAY
        public ActionResult ViewDay()
        {
            var user = db.Users.ToList();
            return View(user);
        }
    }
}