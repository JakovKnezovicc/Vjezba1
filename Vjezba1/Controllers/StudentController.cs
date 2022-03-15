using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vjezba1.Models;

namespace Vjezba1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Početna stranica";
            ViewBag.Fakultet = "Međimursko veleučilište u Čakovcu.";
            return View();
        }
        public ActionResult Popis()
        {
            StudentiDB StudentDB = new StudentiDB();

            return View(StudentDB);
        }
        public ActionResult Detalji(int? id)
        {
            if (id.HasValue)
                RedirectToAction("Popis");
            StudentiDB StudentDB = new StudentiDB();
            //Student Student = StudentDB.VratiListu();
            return View();
        }
    }
}