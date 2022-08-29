using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioVIII
    {
        public void RepasoEj8()
        {
            //Declaración de variables
            DateTime _fecha;
            DateTime _hoy = DateTime.Now;
            double _difFecha;

            //Pido al usuario que ingrese una fecha
            Console.WriteLine("Ingrese una fecha");
            _fecha = Convert.ToDateTime(Console.ReadLine());

            //Calculo la diferencia entre fecha ingresada y la fecha de hoy
            _difFecha = ((_hoy - _fecha).Days);

            //Muestro en pantalla la diferencia en días
            Console.WriteLine("La diferencia entre la fecha ingresada y el día de hoy es de " + _difFecha + " días");
        }
    }
}
