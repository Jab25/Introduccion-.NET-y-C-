using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocios;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        [HttpGet]
        public ActionResult Index()
        {
            NAlumno modelo = new NAlumno();
            List<Alumno> alu = modelo.Consultar();
            return View(alu);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            NAlumno modelo = new NAlumno();
            Alumno alu = modelo.Consultar(Convert.ToInt32(id));
            return View(alu);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            NAlumno modelo = new NAlumno();
            Alumno alu = modelo.Consultar(Convert.ToInt32(id));
            return View(alu);
        }

        [HttpPost]
        public ActionResult Delete(Alumno alumno)
        {
            NAlumno model = new NAlumno();
            model.Eliminar(alumno.id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            NAlumno modelo = new NAlumno();
            modelo.Agregar(alumno);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            NAlumno modelo = new NAlumno();
            Alumno alu = modelo.Consultar(id);
            return View(alu);
        }

        [HttpPost]
        public ActionResult Edit(Alumno alumno)
        {
            NAlumno model = new NAlumno();
            model.Actualizar(alumno);
            return RedirectToAction("Index");
        }
    }
}