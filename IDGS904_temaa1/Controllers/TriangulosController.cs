using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Trinagulos(Triangulo t)
        {
            var triangulo = t.CalcularT();
            ViewBag.Triangulo = triangulo;
            return View();
        }
    }
}