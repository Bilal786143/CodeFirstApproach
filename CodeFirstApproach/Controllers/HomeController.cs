using CodeFirstApproach.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            db.Students.Add(s);
            var a=db.SaveChanges();
            if (a > 0)
            {
                TempData["Create"] = "<script>alert('Created')</script>";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "<script>alert('Not Created')</script>";
                return RedirectToAction("Create");
            }
            
        }

        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(x => x.id == id).FirstOrDefault();
            return View(row);
        }
        
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var row = db.Students.Where(x => x.id == id).FirstOrDefault();
            return View(row);
        }
        public ActionResult Delete(int id)
        {
            var row = db.Students.Where(x => x.id == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed( Student s)
        {
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}