using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioII
    {
        public void RepasoEj2()
        {
            //Declaración de variables
            int _contador = 0;
            int _nroRegistro;
            string acumulador = "";


            //Pido al usuario que ingrese su número de registro
            Console.WriteLine("Ingrese los últimos tres dígitos de su número de registro");
            _nroRegistro = Convert.ToInt32(Console.ReadLine());

            //Si los 3 digitos ingresados comienzan con cero (000 a 099) se le suma 100 al nro de registro
            if (_nroRegistro >= 0 && _nroRegistro <= 99)
            {
                _nroRegistro = _nroRegistro + 100;
            }

            //Estructura iterativa para ir contando los números y mostrarlos en pantalla
            for (_contador = 1; _contador <= _nroRegistro; _contador++)
            {
                if (_contador % 3 == 0 && EsPrimo(_contador))
                {
                    acumulador += _contador + " - Es primo y divisible por 3" + Environment.NewLine;
                }

                else if (_contador % 3 == 0)
                {
                    acumulador += _contador + " - Es divisible por 3" + Environment.NewLine;
                }

                else if (EsPrimo(_contador))
                {
                    acumulador += _contador + " - Es primo" + Environment.NewLine;
                }

                else
                {
                    acumulador += _contador + " - " + Environment.NewLine;
                }
            }

            //Muestro los datos en pantalla
            Console.WriteLine(acumulador);
        }

        public bool EsPrimo(int numero)
        {
            //Declaración de variables
            int contador = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }

            //Si tiene más de dos números que al dividirlos da resto cero entonces no es primo y se devuelve 'false'
            if (contador != 2)
            {
                return false;
            }

            //Si no tiene más de dos números que al dividirlos da resto cero entonces es primo y se devuelve 'true'
            else
            {
                return true;
            }
        }
    }
}
