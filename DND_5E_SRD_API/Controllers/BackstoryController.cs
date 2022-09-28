using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DND_5E_SRD_API.Controllers
{
    public class BackstoryController : Controller
    {
        // GET: BackstoryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BackstoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BackstoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackstoryController/Create
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

        // GET: BackstoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BackstoryController/Edit/5
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

        // GET: BackstoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BackstoryController/Delete/5
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
