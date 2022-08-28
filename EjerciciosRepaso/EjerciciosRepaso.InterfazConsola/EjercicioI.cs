using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioI
    {
        public void RepasoEj1()
        {
            //Declaración de variables
            int _contador;
            int _nroRegistro;
            string acumulador = "";


            //Pido al usuario que ingrese su número de registro
            Console.WriteLine("Ingrese los últimos tres dígitos de su número de registro");
            _nroRegistro = Convert.ToInt32(Console.ReadLine());

            //Si los 3 digitos ingresados comienzan con cero (000 a 099) se le suma 100 al nro de registro
            if(_nroRegistro >= 0 && _nroRegistro <= 99)
            {
                _nroRegistro = _nroRegistro + 100;
            }

            //Estructura iterativa para ir contando los números y mostrarlos en pantalla
            for(_contador = 1; _contador <= _nroRegistro; _contador++)
            {
                if(_contador % 3 == 0 && _contador % 5 == 0)
                {
                    acumulador += _contador + " - FooBar" + Environment.NewLine;
                }

                else if(_contador % 3 == 0)
                {
                    acumulador += _contador + " - Foo" + Environment.NewLine;
                }

                else if (_contador % 5 == 0)
                {
                    acumulador += _contador + " - Bar" + Environment.NewLine;
                }

                else
                {
                    acumulador += _contador + " - " + Environment.NewLine;
                }
            }

            //Muestro los datos en pantalla
            Console.WriteLine(acumulador);
        }
    }
}
