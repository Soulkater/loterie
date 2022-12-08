using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace loterieCda.Controllers
{
    public class ReglesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
