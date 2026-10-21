using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uInvest.Models;

namespace uInvest.Controllers
{
    public class CompanyController : Controller
    {
        private CompanyContext db = new CompanyContext();
        
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.Companies.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            CompanyDto companydto = db.Companies.Find(id);
            if (companydto == null)
            {
                return HttpNotFound();
            }
            return View(companydto);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(CompanyDto companydto)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(companydto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(companydto);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CompanyDto companydto = db.Companies.Find(id);
            if (companydto == null)
            {
                return HttpNotFound();
            }
            return View(companydto);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(CompanyDto companydto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companydto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companydto);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CompanyDto companydto = db.Companies.Find(id);
            if (companydto == null)
            {
                return HttpNotFound();
            }
            return View(companydto);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CompanyDto companydto = db.Companies.Find(id);
            db.Companies.Remove(companydto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}