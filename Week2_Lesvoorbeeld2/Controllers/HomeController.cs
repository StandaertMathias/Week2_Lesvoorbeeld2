using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Week2_Lesvoorbeeld2.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = {"rode kool", "spruitjes","Brocolli","Spinazie" };
        public ViewResult Index(string name)
        {
            ViewBag.groet = DateTime.Now.Hour < 12 ? "Good morning" : "Good evening";
            return View();
        }
        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"De gezochte groente is " +
                    $"de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            }
            return View();
        }
    }
}