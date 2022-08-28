using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioIII
    {
        public void RepasoEj3()
        {
            //Declaración de variables
            string palabra;

            //Pido al usuario que ingrese una palabra
            Console.WriteLine("Ingrese una palabra para comprobar si es palíndromo o no");
            palabra = Console.ReadLine();

            //Se invoca la función para comprobar si la palabra se lee igual al derecho y al revés
            if (EsPalindromo(palabra))
            {
                Console.WriteLine("La palabra" + palabra + " SÍ es palíndromo");
            }
            else
            {
                Console.WriteLine("La palabra" + palabra + " NO es palíndromo");
            }
        }

        public bool EsPalindromo(string palabra)
        {
            //Declaración de variables
            string primeraMitad;
            string segundaMitad;

            primeraMitad = palabra.Substring(0, palabra.Length / 2);
            char [] arr = palabra.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            segundaMitad = temp.Substring(0, temp.Length / 2);

            return primeraMitad.Equals(segundaMitad);
        }
    }
}
