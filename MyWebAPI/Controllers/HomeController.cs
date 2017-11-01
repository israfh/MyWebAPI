using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
      
        public ActionResult Editar()
        {
            var modelo = new PedidoViewModel();
            return View(modelo);
        }

        [HttpPost]
        [ActionName("Editar")]
        [ValidateAntiForgeryToken]
        public ActionResult EditarPost()
        {
            var modelo = new PedidoViewModel();
            TryUpdateModel(modelo);
            if (ModelState.IsValid)
            {

            }

            return Json(new { ok = ModelState.IsValid });
        }
    }
}
