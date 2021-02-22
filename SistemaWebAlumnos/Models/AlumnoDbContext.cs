using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//agregar

namespace SistemaWebAlumnos.Models
{
    public class AlumnoDbContext: DbContext
    {
        public AlumnoDbContext() : base("keyDB") { }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
