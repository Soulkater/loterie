using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loterieCda.Controllers
{
    public class ResultatController : Controller
    {
        // GET: ResultatController
        public ActionResult Resultat()
        {
            return View();
        }

        // GET: ResultatController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResultatController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResultatController/Create
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

        // GET: ResultatController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResultatController/Edit/5
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

        // GET: ResultatController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResultatController/Delete/5
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
