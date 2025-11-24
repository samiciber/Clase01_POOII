using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalCibertec.Models;

namespace PortalCibertec.Controllers
{
    public class CursosController : Controller
    {
        private List<CursoCorto> ObtenerCursos()
        {
            return new List<CursoCorto>
            {
                new CursoCorto
                {
                    Id = 1,
                    Nombre = "Desarrollo Web Full Stack",
                    Duracion = "3 meses",
                    Precio = 1200.00m,
                    Descripcion = "Aprende HTML, CSS, JavaScript y ASP.NET MVC",
                    CuposDisponibles = 25,
                    Instructor = "Ing. Roberto Silva",
                    Modalidad = "Virtual"
                },
                new CursoCorto
                {
                    Id = 2,
                    Nombre = "Excel Empresarial",
                    Duracion = "2 meses",
                    Precio = 800.00m,
                    Descripcion = "Excel desde básico hasta avanzado",
                    CuposDisponibles = 30,
                    Instructor = "Lic. Patricia Ramos",
                    Modalidad = "Presencial"
                }
            };
        }

        // GET: Cursos
        public ActionResult Index()
        {
            var cursos = ObtenerCursos();
            ViewBag.Titulo = "Cursos Cortos - Cibertec";
            return View(cursos);
        }
    }
}