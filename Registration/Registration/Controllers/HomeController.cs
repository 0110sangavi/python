using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblRegistration obj)

        {
            if (ModelState.IsValid)
            {
                RegMVCEntities db = new RegMVCEntities();
                db.tblRegistration.Add(obj);
                db.SaveChanges();

            }
            return View(obj);
        }
    }

    internal interface IAdd<T>
    {
        bools Equals(T obj);
    }

    public class bools
    {
    }

    internal class RegMVCEntities
    {
        public object tblRegistration { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class tblRegistration
    {
    }
}