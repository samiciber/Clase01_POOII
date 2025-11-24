using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalCibertec.Models;

namespace PortalCibertec.Controllers
{
    public class HomeController : Controller
    {
        private List<Carrera> ObtenerCarreras()
        {
            return new List<Carrera>
            {
                new Carrera
                {
                    Id = 1,
                    Nombre = "Computación e Informática",
                    Descripcion = "Desarrolla aplicaciones web y móviles, gestiona bases de datos y aprende programación orientada a objetos.",
                    Duracion = "3 años",
                    Modalidad = "Presencial / Virtual",
                    Destacada = true,
                    PrecioMensual = 450.00m,
                    VacantesDisponibles = 30,
                    Cursos = new List<string>
                    {
                        "Programación Orientada a Objetos II",
                        "Base de Datos Avanzadas",
                        "Desarrollo Web con ASP.NET MVC"
                    }
                },
                new Carrera
                {
                    Id = 2,
                    Nombre = "Marketing Digital",
                    Descripcion = "Domina las estrategias digitales, SEO, SEM, redes sociales y analítica web.",
                    Duracion = "3 años",
                    Modalidad = "Presencial / Virtual",
                    Destacada = true,
                    PrecioMensual = 420.00m,
                    VacantesDisponibles = 35,
                    Cursos = new List<string>
                    {
                        "SEO y SEM",
                        "Community Management",
                        "Google Analytics"
                    }
                }
            };
        }

        // GET: Home/Index
        public ActionResult Index()
        {
            ViewBag.TituloInstituto = "CIBERTEC - Instituto de Educación Superior";
            ViewBag.Mensaje = "Formando profesionales técnicos de excelencia desde 1983";

            var carrerasDestacadas = ObtenerCarreras().Where(c => c.Destacada).ToList();

            return View(carrerasDestacadas);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Acerca de Cibertec";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contáctanos";
            return View();
        }
    }
}