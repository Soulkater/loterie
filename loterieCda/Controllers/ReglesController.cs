using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loterieCda.Controllers
{
    public class ReglesController : Controller
    {
        // GET: ReglesController
        public ActionResult Regles()
        {
            return View();
        }

        // GET: ReglesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReglesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReglesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReglesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReglesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReglesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReglesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
