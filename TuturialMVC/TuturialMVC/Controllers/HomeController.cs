using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuturialMVC.Models;

namespace TuturialMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello World!";
            //System.IO.File.WriteAllText(@"C:\Users\Jose Carlos\Documents\LogMVC.txt",text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            ////ViewBag.RandomNumber = num;
            //if (num > 2000)
            //{
            //    return View("About");
            //}
            //return View("Contact");
            //return RedirectToAction("Contact");
            //return Content("Hola");
            //List<string> names = new List<string>
            //{
            //    "Jose",
            //    "Carlos",
            //    "Cruz"
            //};

            //int number = 5;

            //return View(number);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jose";
            user.LastName = "Cruz";
            user.Age = 34;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Invalid page");
;            return View();
        }

        public ActionResult Contact(int id=0)
        {
            //ViewBag.Message = "Your contact page.";
            ViewBag.Message = id;
            return View();
        }
    }
}