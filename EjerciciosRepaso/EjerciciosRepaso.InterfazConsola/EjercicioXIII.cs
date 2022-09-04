using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioXIII
    {
        public void RepasoEj13()
        {
            //Declaración de variables
            double _numero;
            double _resultado = 0;

            //Pido al usuario que ingrese un número
            Console.WriteLine("Ingrese un número y se calculará su factorial!");
            _numero = Convert.ToDouble(Console.ReadLine());

            //Almaceno el resultado en una variable
            _resultado = FuncionFactorial(_numero);

            //Muestro en pantalla los datos
            Console.WriteLine("El factorial de {0} es: {1}", _numero, _resultado);
        }

        public double FuncionFactorial(double numero)
        {
            if (numero == 0 || numero == 1)
                return 1;
            return numero * FuncionFactorial(numero - 1);
        }
    }
}
