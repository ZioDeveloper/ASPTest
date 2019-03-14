using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPTest.Models;

namespace ASPTest.Controllers
{
    public class TableController : Controller
    {
        private DB_A467AE_ZioDeveloperEntities db = new DB_A467AE_ZioDeveloperEntities();

        // GET: Table
        public ActionResult Index()
        {
            return View(db.TestTable.ToList());
        }

        // GET: Table/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestTable testTable = db.TestTable.Find(id);
            if (testTable == null)
            {
                return HttpNotFound();
            }
            return View(testTable);
        }

        // GET: Table/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descr")] TestTable testTable)
        {
            if (ModelState.IsValid)
            {
                db.TestTable.Add(testTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testTable);
        }

        // GET: Table/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestTable testTable = db.TestTable.Find(id);
            if (testTable == null)
            {
                return HttpNotFound();
            }
            return View(testTable);
        }

        // POST: Table/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descr")] TestTable testTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testTable);
        }

        // GET: Table/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestTable testTable = db.TestTable.Find(id);
            if (testTable == null)
            {
                return HttpNotFound();
            }
            return View(testTable);
        }

        // POST: Table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestTable testTable = db.TestTable.Find(id);
            db.TestTable.Remove(testTable);
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
