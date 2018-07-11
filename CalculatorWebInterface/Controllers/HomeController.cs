using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorWebInterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.operations = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "*",
                    Value = "multiplication"
                },
                new SelectListItem
                {
                    Text = "/",
                    Value = "division"
                },
                new SelectListItem
                {
                    Text = "+",
                    Value = "addition"
                },
                new SelectListItem
                {
                    Text = "-",
                    Value = "subsraction"
                }
            };
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

        [HttpPost]
        public ActionResult Index(double firstArgument, double secondArgument, string operation)
        {
            ViewBag.operations = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "*",
                    Value = "multiplication"
                },
                new SelectListItem
                {
                    Text = "/",
                    Value = "division"
                },
                new SelectListItem
                {
                    Text = "+",
                    Value = "addition"
                },
                new SelectListItem
                {
                    Text = "-",
                    Value = "subsraction"
                }
            };


            return View();
        }
    }
}