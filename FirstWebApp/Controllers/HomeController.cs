using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyModal obj = new MyModal();

            obj.Id = 143;
            obj.Name = "Aditya Yadav";
            obj.Age = 21;
            obj.Salary = 15000;
            obj.Email = "adityayadavbhtr@gmail.com";

            return View(obj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.abc = "Hii from Chetu India..!";
            ViewBag.abc1 = 12345;
            ViewBag.abc2 = 12.35;
            ViewBag.abc3 = 12.5f;
            ViewBag.abc4 = true;
            ViewBag.abc5 = DateTime.Now;
            ViewBag.List = new List<string>()
            {
                "Mumbai",
                "Noida",
                "Delhi",
                "Deoria"
            };

            ViewData["abc"] = "Hii from Chetu India..!";
            ViewData["abc1"] = 12345;
            ViewData["abc2"] = 12.35;
            ViewData["abc3"] = 12.5f;
            ViewData["abc4"] = true;
            ViewData["abc5"] = DateTime.Now;
            ViewData["List"] = new List<string>()
            {
                "Mumbai",
                "Noida",
                "Delhi",
                "Deoria"
            };

            TempData["abc"] = "Hii from Chetu India..!";
            TempData["abc1"] = 12345;
            TempData["abc2"] = 12.35;
            TempData["abc3"] = 12.5f;
            TempData["abc4"] = true;
            TempData["abc5"] = DateTime.Now;
            TempData["List"] = new List<string>()
            {
                "Kanpur",
                "Noida",
                "Delhi",
                "Agra"
            };


            Session["abc"] = "Hii from Chetu India..!";
            Session["abc1"] = 12345;
            Session["abc2"] = 12.35;
            Session["abc3"] = 12.5f;
            Session["abc4"] = true;
            Session["abc5"] = DateTime.Now;
            Session["List"] = new List<string>()
            {
                "Kanpur",
                "Noida",
                "Delhi",
                "Agra"
            };

            return View();
        }
    }
}