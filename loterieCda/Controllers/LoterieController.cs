using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loterieCda.Controllers
{
    public class LoterieController : Controller
    {
        // GET: LoterieController
        public ActionResult Loterie()
        {
            return View();
        }

        // GET: LoterieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoterieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoterieController/Create
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

        // GET: LoterieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoterieController/Edit/5
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

        // GET: LoterieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoterieController/Delete/5
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
