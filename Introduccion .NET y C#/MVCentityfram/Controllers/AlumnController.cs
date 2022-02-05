using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCent.Models;
using System.Threading.Tasks;

namespace MVCent.Controllers
{
    public class AlumnController : Controller
    {
        
        // GET: Alumn
        public ActionResult Index()
        {
            CapacitacionEntities1 dbContext = new CapacitacionEntities1();
            DbSet<Alumnos> llenar = dbContext.Alumnos;
            return View(llenar);
        }

        // GET: Alumn/Details/5
        public ActionResult Details(int id)
        {
            CapacitacionEntities1 dbContext = new CapacitacionEntities1();
            DbSet<Alumnos> llenar = dbContext.Alumnos;
            
            return View(llenar.Find(id));
        }

        // GET: Alumn/Create
        public ActionResult Create()
        {
            CapacitacionEntities1 dbContext = new CapacitacionEntities1();
            List<Estados> list = dbContext.Estados.ToList();
            List<EstatusAlumnos> lista = dbContext.EstatusAlumnos.ToList();
            ViewBag.idEstadoOrigen = new SelectList(list, "id_Estados", "nombre");
            ViewBag.idEstatus = new SelectList(lista, "id_EstatusAlumnos", "Nombre");
            return View();
        }

        // POST: Alumn/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumnos)
        {
            try
            {
                // TODO: Add insert logic here
                CapacitacionEntities1 dbContext = new CapacitacionEntities1();
                DbSet<Alumnos> llen = dbContext.Alumnos;
                llen.Add(alumnos);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumn/Edit/5
        public ActionResult Edit(int id)
        {
            CapacitacionEntities1 dbContext = new CapacitacionEntities1();
            DbSet<Alumnos> llenar = dbContext.Alumnos;
            Alumnos alumnos = llenar.Find(id);
            List<Estados> list = dbContext.Estados.ToList();
            List<EstatusAlumnos> lista = dbContext.EstatusAlumnos.ToList();
            ViewBag.idEstadoOrigen = new SelectList(list, "id_Estados", "nombre", alumnos.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(lista, "id_EstatusAlumnos", "Nombre", alumnos.idEstatus);
            
            return View(alumnos);
        }

        // POST: Alumn/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumnos alumnos)
        {
            try
            {
                // TODO: Add update logic here
                CapacitacionEntities1 dbContext = new CapacitacionEntities1();
                DbSet<Alumnos> llen = dbContext.Alumnos;
                dbContext.Entry(alumnos).State = EntityState.Modified;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumn/Delete/5
        public ActionResult Delete(int id)
        {
            CapacitacionEntities1 dbContext = new CapacitacionEntities1();
            DbSet<Alumnos> llenar = dbContext.Alumnos;

            return View(llenar.Find(id));
        }

        // POST: Alumn/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Alumnos alumnos)
        {
            try
            {
                // TODO: Add delete logic here
                CapacitacionEntities1 dbContext = new CapacitacionEntities1();
                DbSet<Alumnos> llen = dbContext.Alumnos;
                Alumnos eli = llen.Find(id);
                llen.Remove(eli);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
