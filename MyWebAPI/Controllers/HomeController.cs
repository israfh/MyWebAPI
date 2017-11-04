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
            OrdenarLista();

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

       private void  OrdenarLista()
        {
            var lista = new List<Item>();
            lista.Add(new Item() { Id=1, IdDpte=null });
            lista.Add(new Item() { Id = 2, IdDpte = 1 });
            lista.Add(new Item() { Id = 3, IdDpte = 2 });
            lista.Add(new Item() { Id = 4, IdDpte = 5 });
            lista.Add(new Item() { Id = 5, IdDpte = null });

            var lista2 = new List<Item>();
            lista.Where(x => x.IdDpte == null).ToList().ForEach(x => {

                lista2.AddRange(lista.Where(y => y.IdDpte == x.Id));
            });
         


        }


       
    }
}
