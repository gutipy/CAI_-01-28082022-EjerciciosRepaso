using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso.InterfazConsola
{
    public class EjercicioV
    {
        public void RepasoEj5()
        {

            char[] _numeroAInvertir = Console.ReadLine().ToCharArray();

            Array.Reverse(_numeroAInvertir);

            string _numeroInvertido = new string(_numeroAInvertir);

            Console.WriteLine(_numeroInvertido);
        }
    }
}
