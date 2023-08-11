using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormwithDropDown.Controllers
{
    public class RegeistrationController : Controller
    {
        // GET: RegeistrationController
        public ActionResult Index()
        {
            return View("Insert");
        }

        // GET: RegeistrationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegeistrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegeistrationController/Create
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

        // GET: RegeistrationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegeistrationController/Edit/5
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

        // GET: RegeistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegeistrationController/Delete/5
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
