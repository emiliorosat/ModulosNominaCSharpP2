using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sistema_Parcial_Nomina.Models;

namespace Sistema_Parcial_Nomina.Controllers
{
    public class NominasController : Controller
    {
        private DatabaseEntities2 db = new DatabaseEntities2();

        // GET: Nominas
        public ActionResult Index()
        {
            return View(db.Nomina.ToList());
        }

        // GET: Nominas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomina nomina = db.Nomina.Find(id);
            if (nomina == null)
            {
                return HttpNotFound();
            }
            return View(nomina);
        }

        // GET: Nominas/Create
        public ActionResult Create()
        {
           List<Empleados> empleados = db.Empleados.SqlQuery("select * from Empleados where Estado = 1").ToList<Empleados>();
            double monto = 0;
            foreach(var empleado in empleados)
            {
                monto += empleado.Salario.GetValueOrDefault();
            }

            ViewData["MontoNomina"] = monto;

            return View();
        }

        // POST: Nominas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ano,Mes,Fecha,Nomina1")] Nomina nomina)
        {
            nomina.Fecha = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Nomina.Add(nomina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nomina);
        }

        // GET: Nominas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomina nomina = db.Nomina.Find(id);
            if (nomina == null)
            {
                return HttpNotFound();
            }
            return View(nomina);
        }

        // POST: Nominas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ano,Mes,Fecha,Nomina1")] Nomina nomina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nomina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nomina);
        }

        // GET: Nominas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomina nomina = db.Nomina.Find(id);
            if (nomina == null)
            {
                return HttpNotFound();
            }
            return View(nomina);
        }

        // POST: Nominas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nomina nomina = db.Nomina.Find(id);
            db.Nomina.Remove(nomina);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
