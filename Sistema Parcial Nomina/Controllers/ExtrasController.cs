using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_Parcial_Nomina.Models.Extras;

namespace Sistema_Parcial_Nomina.Controllers
{
    public class ExtrasController : Controller
    {
        // GET: Extras
        public ActionResult Sumadora()
        {
            return View();
        }

        public ActionResult ResultadoCalculadora( CalculadorFacade calc)
        {
            calc.EjecutarOperacion();

            return View(calc);
        }

        public ActionResult Conversor()
        {
            return View();
        }

        public ActionResult ResultadoConversor(ConversorFacade obj)
        {
            obj.EjecutarConversion();
            return View(obj);
        }



        public ActionResult Index()
        {
            return View();
        }
    }
}