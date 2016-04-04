using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ConfCore.Web.Models;

namespace ConfCore.Web.Controllers
{
    public class PresentersController : Controller
    {
        private ConfCoreDbContext _context;

        public PresentersController(ConfCoreDbContext context)
        {
            _context = context;    
        }

        // GET: Presenters
        public IActionResult Index()
        {
            return View(_context.Presenters.ToList());
        }

        // GET: Presenters/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Presenter presenter = _context.Presenters.Single(m => m.Id == id);
            if (presenter == null)
            {
                return HttpNotFound();
            }

            return View(presenter);
        }

        // GET: Presenters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Presenters/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Presenter presenter)
        {
            if (ModelState.IsValid)
            {
                _context.Presenters.Add(presenter);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(presenter);
        }

        // GET: Presenters/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Presenter presenter = _context.Presenters.Single(m => m.Id == id);
            if (presenter == null)
            {
                return HttpNotFound();
            }
            return View(presenter);
        }

        // POST: Presenters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Presenter presenter)
        {
            if (ModelState.IsValid)
            {
                _context.Update(presenter);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(presenter);
        }

        // GET: Presenters/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Presenter presenter = _context.Presenters.Single(m => m.Id == id);
            if (presenter == null)
            {
                return HttpNotFound();
            }

            return View(presenter);
        }

        // POST: Presenters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Presenter presenter = _context.Presenters.Single(m => m.Id == id);
            _context.Presenters.Remove(presenter);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
