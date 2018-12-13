using Project2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private DefaultConnection db = new DefaultConnection();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.caseSize = db.Cases.Count();
            ViewBag.taskSize = db.Tasks.Count();
            ViewBag.clientSize = db.Clients.Count();

            ViewBag.tasks = db.Tasks.ToList();
           
            return View();
        }
    }
}