using cargaacademicaInformatica.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cargaacademicaInformatica.Web.Controllers
{
    public class AsignaturasController : Controller
    {
        // GET: Asignaturas
        public ActionResult Index()
        {
            var asignaturasBL = new AsiganturasBL();
            var ListaAsignaturas = asignaturasBL.ObtenerAsignaturas();

            return View(ListaAsignaturas);
        }
    }
}