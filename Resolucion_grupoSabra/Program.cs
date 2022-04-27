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
            //MostrarDatos();
            MostrarDatos_puntoB();

        }
        /*Realizar una aplicación de consola que ordene un array de números enteros ingresados por
            parámetro. Y también devolver el promedio.*/
        private static void MostrarDatos_puntoB()
        {
            try
            {
                Console.WriteLine("Ingrese el tamaño del array: ");
                int tamañoArray = int.Parse(Console.ReadLine());
                var arrayNros = new int[tamañoArray];
                for (int i = 0; i<tamañoArray; i++)
                {
                    Console.WriteLine($"Ingrese valor para la posicion {i.ToString()}: ");
                    string nroIngresado = Console.ReadLine();
                    if (int.TryParse(nroIngresado, out arrayNros[i])) 
                    {

                    }                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }            
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
