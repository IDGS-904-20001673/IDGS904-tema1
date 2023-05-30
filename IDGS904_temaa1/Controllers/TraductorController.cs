using IDGS904_temaa1.Models;
using IDGS904_temaa1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_temaa1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor

        public ActionResult RegistrarTraductor()
        {
            Array archivo = null;
            if (TempData.ContainsKey("Archivo"))
            {
                archivo = TempData["Archivo"] as Array;
            }
            ViewBag.Archivo = archivo;

            return View();
        }

        [HttpPost]
        public ActionResult RegistrarTraductor(Traductor y)
        {
            var g = new TraductorGuardarServices();
            g.GuardaArchivo(y); 
            return View();

        }

        public RedirectToRouteResult LeerDatos()
        {
            var tra = new LeerPalabras();
            
            TempData["Archivo"] = tra.LeerArchivo(); ;
            return RedirectToAction("RegistrarTraductor");
        }

        public ActionResult MostrarPalabra(Traductor t)
        {
            if (t.llave is null)
            {
                ViewBag.palabra="Traductor";
            }
            else
            {
                var valor = t.Palabra();
                ViewBag.palabra = valor;
            }
            return View();
        }
    }
}