using myapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myapp.Controllers
{
    public class HomeController : Controller
    {
        private SchoolDBEntities db = new SchoolDBEntities();
        public ActionResult Index()
        {
            ViewBag.Health = Health().ToString();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string Health()
        {
            var vmname = Environment.MachineName;

            var result = String.Format("500 FROM VM {0}", vmname);


            var courses = from c in db.Course
                          select c;

            try
            {
                if (courses.Count() > 0)
                {
                    result = String.Format("200 FROM VM {0}", vmname);
                }
            }
            catch(Exception exc)
            {
                result = String.Format("501 FROM VM {0}: exception: {1}", vmname, exc.Message);
            }

            return result;
        }
    }
}