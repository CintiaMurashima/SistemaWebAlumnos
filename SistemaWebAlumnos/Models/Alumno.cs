using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebAlumnos.Models
{
    public class Alumno
    {

        [Key]
        [Required]
        public int AlumnoID { get; set; }

        [Required(ErrorMessage = "The name is required")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "The lastname is required")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "The DNI is required")]
        public string DNI { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "The Email is required")]
        public string Email { get; set; }

       
    }
}