using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cargaacademicaInformatica.BL
{
    public class AsiganturasBL
    {

        public List<Asignatura> ObtenerAsignaturas()
        {
            var Asignatura1 = new Asignatura();
            Asignatura1.Seccion = "1600";
            Asignatura1.Edificio = "5";
            Asignatura1.NombreAsignatura = "Lenguaje de Programacion 3";
            Asignatura1.NombreCatedratico = "Franklin Xavier Rodriguez Santos";

            var Asignatura2 = new Asignatura();

            Asignatura2.Seccion = "1700";
            Asignatura2.Edificio = "5";
            Asignatura2.NombreAsignatura = "Base de Datos 1";
            Asignatura2.NombreCatedratico = "Edgar Antonio Zuniga";

            var Asignatura3 = new Asignatura();

            Asignatura3.Seccion = "1400";
            Asignatura3.Edificio = "5";
            Asignatura3.NombreAsignatura = "Taller de Hardware 2";
            Asignatura3.NombreCatedratico = "Noe Mejia";


            var ListaAsignaturas = new List<Asignatura>();

            ListaAsignaturas.Add(Asignatura1);
            ListaAsignaturas.Add(Asignatura2);
            ListaAsignaturas.Add(Asignatura3);


            return ListaAsignaturas;
            

            }
            
    }
}
