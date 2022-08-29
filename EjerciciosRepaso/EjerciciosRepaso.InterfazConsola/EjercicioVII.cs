using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioVII
    {
        public void RepasoEj7()
        {
            //Declaración de variables
            int[] arrayNumeros = new int[5];
            int numero;
            int max;
            int min;

            //Estructura iterativa para que el usuario ingrese los 5 números
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine("Ingrese el número #0" + (i + 1));
                numero = Convert.ToInt32(Console.ReadLine());

                //Guardo cada número en el arreglo
                arrayNumeros[i] = numero;
            }

            //Guardo en variables el número mayor y menor
            max = arrayNumeros.Max();

            min = arrayNumeros.Min();

            //Muestro en pantalla el número mayor y menor
            Console.WriteLine(
                "El mayor de los números ingresados es: " + max + Environment.NewLine +
                "El menor de los números ingresados es: " + min + Environment.NewLine
                )
                ;
        }
    }
}
