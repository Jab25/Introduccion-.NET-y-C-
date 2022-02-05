using Entidades;
using Negocios;
using Negocios.WCFservicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            NAlumno modelo = new NAlumno();
            List<Alumnos> alu = modelo.Consultar();
            return View(alu);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int? id)
        {
            id = id ?? 10;
            NAlumno modelo = new NAlumno();
            Alumnos alu = modelo.Consultar(Convert.ToInt32(id));
            return View(alu);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            NEstado nEstado = new NEstado();
            NEstatusAlumno nEstatusAlumno = new NEstatusAlumno();
            List<Estados> estados = nEstado.Consultar();
            List<EstatusAlumnos> estatusAlumnos = nEstatusAlumno.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "id_Estados", "nombre");
            ViewBag.idEstatus = new SelectList(estatusAlumnos, "id_EstatusAlumnos", "Nombre");

            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    NAlumno modelo = new NAlumno();
                    modelo.Agregar(alumno);
                    return RedirectToAction("Index");
                }
                // TODO: Add insert logic here                
            }
            catch
            {
                
            }
            NEstado nEstado = new NEstado();
            NEstatusAlumno nEstatusAlumno = new NEstatusAlumno();
            List<Estados> estados = nEstado.Consultar();
            List<EstatusAlumnos> estatusAlumnos = nEstatusAlumno.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "id_Estados", "nombre");
            ViewBag.idEstatus = new SelectList(estatusAlumnos, "id_EstatusAlumnos", "Nombre");

            return View(alumno);
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            NAlumno alum = new NAlumno();
            NEstado nEstado = new NEstado();
            NEstatusAlumno nEstatusAlumno = new NEstatusAlumno();
            Alumnos idcons = alum.Consultar(id);
            List<Estados> estados = nEstado.Consultar();
            List<EstatusAlumnos> estatusAlumnos = nEstatusAlumno.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "id_Estados", "nombre", idcons.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(estatusAlumnos, "id_EstatusAlumnos", "Nombre", idcons.idEstatus);

            NAlumno modelo = new NAlumno();
            Alumnos alu = modelo.Consultar(id);
            return View(alu);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumnos alumnos)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    NAlumno model = new NAlumno();
                    model.Actualizar(alumnos);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                
            }
            NEstado nEstado = new NEstado();
            NEstatusAlumno nEstatusAlumno = new NEstatusAlumno();
            List<Estados> estados = nEstado.Consultar();
            List<EstatusAlumnos> estatusAlumnos = nEstatusAlumno.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "id_Estados", "nombre", alumnos.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(estatusAlumnos, "id_EstatusAlumnos", "Nombre", alumnos.idEstatus);
            return View(alumnos);
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            NAlumno modelo = new NAlumno();
            Alumnos alu = modelo.Consultar(Convert.ToInt32(id));
            return View(alu);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Alumnos alumnos)
        {
            try
            {
                // TODO: Add delete logic here
                NAlumno model = new NAlumno();
                model.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult _AportacionesIMSS(int id)
        {
            NAlumno nAlumno = new NAlumno();
            AportacionesIMSS imss = nAlumno.CalcularIMMS(id);
            return PartialView(imss);
        }

        public ActionResult _TablaISR(int id)
        {
            NAlumno nAlumno = new NAlumno();
            TablaISR isr = nAlumno.CalcularISR(id);
            return PartialView(isr);
        }
    }
}
