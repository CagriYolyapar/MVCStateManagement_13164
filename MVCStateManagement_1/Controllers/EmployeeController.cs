using MVCStateManagement_1.DesignPatterns.SingletonPattern;
using MVCStateManagement_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStateManagement_1.Controllers
{
    public class EmployeeController : Controller
    {
        NorthwindEntities _db;

        public EmployeeController()
        {
            _db = DBTool.DBInstance;
        }
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Employee item)
        {
            if (_db.Employees.Any(x => x.FirstName == item.FirstName && x.LastName == item.LastName))
            {
                Session["emp"] = _db.Employees.FirstOrDefault(x => x.FirstName == item.FirstName && x.LastName == item.LastName);

                return RedirectToAction("GreetTheEmployee");
            }
            ViewBag.KullaniciYok = "Kullanici bulunamadı";




            return View();
        }

        public ActionResult GreetTheEmployee()
        {
            return View();
        }
    }
}