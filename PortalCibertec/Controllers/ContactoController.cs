using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalCibertec.Models;

namespace PortalCibertec.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Mensaje = "Solicita información sobre nuestras carreras";
            return View();
        }

        // POST: Contacto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SolicitudInformacion solicitud)
        {
            if (ModelState.IsValid)
            {
                TempData["Mensaje"] = $"¡Gracias {solicitud.NombreCompleto}! Nos contactaremos pronto.";
                return RedirectToAction("Confirmacion");
            }

            return View(solicitud);
        }

        // GET: Contacto/Confirmacion
        public ActionResult Confirmacion()
        {
            if (TempData["Mensaje"] == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Mensaje = TempData["Mensaje"];
            return View();
        }
    }
}