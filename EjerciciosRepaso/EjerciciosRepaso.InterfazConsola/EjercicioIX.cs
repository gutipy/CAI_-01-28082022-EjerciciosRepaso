using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioIX
    {
        public void RepasoEj9()
        {
            //Declaración de variables
            string _nombreUsuario;
            
            //Pido al usuario que ingrese su nombre
            Console.WriteLine("Ingrese su nombre!");
            _nombreUsuario = Console.ReadLine();

            //Transformo la cadena ingresada en minuscula
            _nombreUsuario.ToLower();

            //Condicional para mostrar en pantalla
            if(_nombreUsuario == "agustin")
            {
                Console.WriteLine("¡Hola, " + _nombreUsuario + "!");
            }
            else
            {
                Console.WriteLine("No te conozco!");
            }
        }
    }
}
