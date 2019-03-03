using cargaacademicaInformatica.Web.Models;
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
            var asignaturas = new Asignaturas();
            asignaturas.Id=0;
            asignaturas.Descripcion = "Asignaturas Disponibles";

            var asignaturas1 = new Asignaturas();
            asignaturas1.Id = 1;
            asignaturas1.Descripcion = "Lenguaje4";
         
            var asignaturas2 = new Asignaturas();
            asignaturas2.Id = 2;
            asignaturas2.Descripcion = "Taller de Hardware";

            var asignaturas3 = new Asignaturas();
            asignaturas3.Id = 3;
            asignaturas3.Descripcion = "Teoria de Sistema";

            var listadeAsignaturas = new List<Asignaturas>();
            listadeAsignaturas.Add(asignaturas);
            listadeAsignaturas.Add(asignaturas1);
            listadeAsignaturas.Add(asignaturas2);
            listadeAsignaturas.Add(asignaturas3);

            return View(listadeAsignaturas);
        }
    }
}