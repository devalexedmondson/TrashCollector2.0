using Microsoft.AspNet.Identity;
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
        ApplicationDbContext db;

        public CustomerController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult CustomerIndex()
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            return View(user);
        }

        //CUSTOMER/CHANGEDAY GET
        //GET: Customer/ChangeDay
        public ActionResult ChangeDay()
        {
            ViewBag.Name = new SelectList(db.PickUpOption.ToList(), "Day", "Day");
            return View();
        }

        //CUSTOMER/CHANGEDAY POST
        //POST: Customer/ChangeDay 
        [HttpPost]
        public ActionResult ChangeDay(ChangeDayViewModel model)
        {
            var user = db.Users.Find(User.Identity.GetUserId());

            //need to store day w/o adding new day to PickUpOption
            var pickUpOption = new PickUpOption
            {
                Day = model.PickUpDay
            };
            user.PickUpOption = pickUpOption;
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("CustomerIndex", "Customer");
        }

        //CUSTOMER/ADDADDRESS 
        //GET: Customer/AddAddress
        public ActionResult AddAddress()
        {
            return View();
        }

        //CUSTOMER/ADDADDRESS
        //POST: Customer/AddAddress
        [HttpPost]
        public ActionResult AddAddress(AddAddressViewModel model)
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            user.Address = model.Address;


            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View("CustomerIndex");
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