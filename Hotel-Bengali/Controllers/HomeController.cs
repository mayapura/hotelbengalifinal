using Hotel_Bengali.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Bengali.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Your application Index page.";
            var vistaModel = new vista();

            var ListaFormasDePago = new List<SelectListItem>();
            ListaFormasDePago.Add(new SelectListItem {Value = "1", Text = "Efectivo"});
            ListaFormasDePago.Add(new SelectListItem { Value = "2", Text = "Debito" });
            ListaFormasDePago.Add(new SelectListItem { Value = "3", Text = "Credito" });

            var TipoPagos = new SelectList(ListaFormasDePago, "Value", "Text");
            ViewBag.ListaFormasDePago = TipoPagos;

            var ListaGenero = new List<SelectListItem>();
            ListaGenero.Add(new SelectListItem {Value ="1", Text = "Femenino" });
            ListaGenero.Add(new SelectListItem { Value = "2", Text = "Masculino" });
            ListaGenero.Add(new SelectListItem { Value = "3", Text = "Otro" });

            var TipoGenero = new SelectList(ListaGenero, "Value", "Text");
            ViewBag.ListaGenero = TipoGenero;

            return View(vistaModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Reservas()
        {
            ViewBag.Message = "Mi pagina de reservas";

            return View();
        }

        [HttpPost]
        public ActionResult GuardarReserva(Pago pago) 
        {

            return RedirectToAction("Index");
        }

    }
}