using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucion_grupoSabra
{
    class Program
    {
        /*a) Realizar una aplicación de consola que muestre como salida 15 líneas como estas.
            1
            12
            123
            1234
            ... (hasta tener las 15 líneas, y en la última tener los 15 dígitos)
        */
        static void Main(string[] args)
        {
            MostrarDatos_puntoA();
        }

       

        private static void MostrarDatos_puntoA()
        {
            string nrosConcatenados = String.Empty;
            for(int i = 1; i <= 15; i++)
            {
                nrosConcatenados += i.ToString();
                Console.WriteLine(nrosConcatenados);
            }
            Console.ReadLine();
        }
    }
}
