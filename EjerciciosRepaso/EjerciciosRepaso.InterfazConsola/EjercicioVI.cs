using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioVI
    {
        public void RepasoEj6()
        {
            //Declaración de variables
            int numero1;
            int numero2;
            int resultado = 0;

            //Pido al usuario que ingrese dos números
            Console.WriteLine("Ingrese un número");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro número");
            numero2 = Convert.ToInt32(Console.ReadLine());

            //Invoco a la función que calcula la operación aritmética entre ambos números y guardo el resultado en la variable
            resultado = OperacionAritmetica(numero1, numero2);

            //Muestro en pantalla el resultado
            Console.WriteLine("La operación aritmética entre el número " + numero1 + " y el número " + numero2 + " es igual a: " + resultado);
        }

        public int OperacionAritmetica(int num1, int num2)
        {
            //Declaración de variables
            int resultado;

            //Realizo la operación entre los dos números
            resultado = (num1 + num2) * (num1 - num2);

            //Devuelvo resultado de la operación
            return resultado;
        }
    }
}
