using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioX
    {
        //Declaración de arreglos necesarios para validaciones
        string[] Vocales = new string[] {"a", "e", "i", "o", "u"};
        string[] Consonantes = new string[] {"b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "ñ", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"};
        string[] Numeros = new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        public void RepasoEj10()
        {
            //Declaración de variables
            string _caracter = "";

            //Invoco a la función para validar el imput del usuario
            ValidarCaracter(ref _caracter);

            //Transformo en minúsculas la cadena ingresada por el usuario
            _caracter.ToLower();

            //Condicional para determinar que se ingresó (vocal, número o consonante) y se muestra en pantalla
            foreach(string valor in Vocales)
            {
                if(valor == _caracter)
                {
                    Console.WriteLine("Usted ingreso una vocal: " + valor);
                }
            }

            foreach (string valor in Consonantes)
            {
                if (valor == _caracter)
                {
                    Console.WriteLine("Usted ingreso una consonante: " + valor);
                }
            }

            foreach (string valor in Numeros)
            {
                if (valor == _caracter)
                {
                    Console.WriteLine("Usted ingreso un número: " + valor);
                }
            }


        }

        public bool ValidarCaracter(ref string cadena)
        {
            //Declaración de variables
            bool flag = false;

            //Validación del imput del usuario
            do
            {
                //Pido al usuario que ingrese un caracter
                Console.WriteLine("Ingrese UN (1) caracter");
                cadena = Console.ReadLine();

                //Valido que no se haya ingresado un vacío
                if (string.IsNullOrEmpty(cadena))
                {
                    Console.WriteLine("ERROR! El valor ingresado no puede ser vacío");
                }
                else if(cadena.Length > 1)
                {
                    Console.WriteLine("ERROR! No se puede ingresar más de un caracter, intente nuevamente");
                }
                else if(!Regex.IsMatch(cadena, "^[a-zA-Z0-9]*$"))
                {
                    Console.WriteLine("ERROR! No se permiten caracteres especiales, intente nuevamente");
                }
                else
                {
                    flag = true;
                }
            } while (flag == false);

            return flag;

        }
    }
}
