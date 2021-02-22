using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaWebAlumnos.Models;

namespace SistemaWebAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        private AlumnoDbContext context = new AlumnoDbContext();
        // GET: Alumno
        public ActionResult Index()
        {
            return View("Index", context.Alumnos.ToList());
        }

        public ActionResult Detail(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View("Display", alumno);
        }

        public ActionResult Create()
        {
            Alumno newAlumno = new Alumno();
            return View("Create", newAlumno);
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {

            if (!ModelState.IsValid)
            {
                return View("Create", alumno);
            }
            context.Alumnos.Add(alumno);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int ?id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View("Delete", alumno);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            context.Alumnos.Remove(alumno);
            context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}

