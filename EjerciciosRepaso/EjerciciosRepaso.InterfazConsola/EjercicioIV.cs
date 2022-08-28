using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioIV
    {
        public void RepasoEj4()
        {
            //Declaración de variables
            string palabra1;
            string palabra2;

            //Pido al usuario que ingrese las dos palabras
            Console.WriteLine("Ingrese la palabra 1: ");
            palabra1 = Console.ReadLine();

            Console.WriteLine("Ingrese la palabra 2: ");
            palabra2 = Console.ReadLine();

            if(EsAnagrama(palabra1, palabra2))
            {
                Console.WriteLine("La palabra " + palabra1 + " y la palabra " + palabra2 + " SÍ son anagramas");
            }
            else
            {
                Console.WriteLine("La palabra " + palabra1 + " y la palabra " + palabra2 + " NO son anagramas");
            }
        }

        public bool EsAnagrama(string cadena1, string cadena2)
        {
            //Declaración de variables

            if (cadena1.Equals(new string(cadena2.Reverse().ToArray())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
