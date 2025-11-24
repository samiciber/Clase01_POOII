using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortalCibertec.Models
{
    public class CursoCorto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del curso es obligatorio")]
        public string Nombre { get; set; }

        public string Duracion { get; set; }

        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }

        public int CuposDisponibles { get; set; }

        public string Instructor { get; set; }

        public string Horario { get; set; }

        public string Modalidad { get; set; }
    }
}