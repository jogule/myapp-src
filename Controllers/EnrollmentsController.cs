using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using myapp.Models;

namespace myapp.Controllers
{
    public class EnrollmentsController : Controller
    {
        private SchoolDBEntities db = new SchoolDBEntities();

        // GET: Enrollments
        public ActionResult Index()
        {
            return View(db.View_StudentCourse.ToList());
        }

        // GET: Enrollments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            View_StudentCourse view_StudentCourse = db.View_StudentCourse.Find(id);
            if (view_StudentCourse == null)
            {
                return HttpNotFound();
            }
            return View(view_StudentCourse);
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
