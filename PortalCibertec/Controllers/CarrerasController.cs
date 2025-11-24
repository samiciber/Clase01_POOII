using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalCibertec.Models;

namespace PortalCibertec.Controllers
{
    public class CarrerasController : Controller
    {
        private List<Carrera> ObtenerCarreras()
        {
            return new List<Carrera>
            {
                new Carrera
                {
                    Id = 1,
                    Nombre = "Computación e Informática",
                    Descripcion = "Desarrolla aplicaciones web y móviles.",
                    Duracion = "3 años",
                    Modalidad = "Presencial / Virtual",
                    PrecioMensual = 450.00m,
                    VacantesDisponibles = 30,
                    Cursos = new List<string>
                    {
                        "Programación Orientada a Objetos II",
                        "Base de Datos Avanzadas",
                        "Desarrollo Web"
                    }
                },
                new Carrera
                {
                    Id = 2,
                    Nombre = "Marketing Digital",
                    Descripcion = "Domina estrategias digitales.",
                    Duracion = "3 años",
                    Modalidad = "Presencial / Virtual",
                    PrecioMensual = 420.00m,
                    VacantesDisponibles = 35,
                    Cursos = new List<string>
                    {
                        "SEO y SEM",
                        "Community Management"
                    }
                }
            };
        }

        // GET: Carreras
        public ActionResult Index()
        {
            var carreras = ObtenerCarreras();
            return View(carreras);
        }

        // GET: Carreras/Detalle/1
        public ActionResult Detalle(int id)
        {
            var carrera = ObtenerCarreras().FirstOrDefault(c => c.Id == id);

            if (carrera == null)
            {
                return RedirectToAction("Index");
            }

            return View(carrera);
        }
    }
}