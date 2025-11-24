using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortalCibertec.Models
{
    public class Carrera
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; }


        [StringLength(500)]
        public string Descripcion { get; set; }


        [Required]
        public string Duracion { get; set; }

        public string Modalidad { get; set; }

        public string imagen { get; set; }

        public List<string> Cursos { get; set; }

        public bool Destacada { get; set; }

        public decimal PrecioMensual { get; set; }
        
        public int VacantesDisponibles { get; set; }

    }
}