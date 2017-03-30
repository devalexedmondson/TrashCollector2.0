using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector2._0.Models;

namespace TrashCollector2._0.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerIndex()
        {
            return View();
        }

        //CUSTOMER/CHANGEDAY GET
        //GET: Customer/ChangeDay
        public ActionResult ChangeDay()
        {
            return View();
        }

        //CUSTOMER/CHANGEDAY POST
        //POST: Customer/ChangeDay 
        [HttpPost]
        public ActionResult ChangeDay(ChangeDayViewModel model)
        {
            return View();
        }

        //CUSTOMER/VACATIONDAY GET
        //GET: Customer/VacationDay
        public ActionResult VacationDay()
        {
            return View();
        }

        //CUSTOMER/VACATIONDAY POST
        //Customer/VacationDay
        [HttpPost]
        public ActionResult VacationDay(VacationDayViewModel model)
        {
            return View();
        }
    }
}