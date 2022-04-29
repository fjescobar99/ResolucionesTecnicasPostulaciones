using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoB
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarDatos_puntoB();
        }
        private static void MostrarDatos_puntoB()
        {
            try
            {
                Console.WriteLine("Ingrese el tamaño del array: ");
                int tamañoArray = int.Parse(Console.ReadLine());
                var arrayNros = new int[tamañoArray];
                for (int i = 0; i < tamañoArray; i++)
                {
                    Console.WriteLine($"Ingrese valor para la posicion {i.ToString()}: ");
                    string nroIngresado = Console.ReadLine();
                    if (!int.TryParse(nroIngresado, out arrayNros[i]))
                    {
                        i -= 1;
                    }
                }
                Console.WriteLine("Array de nros: ");
                ImprimirArray(arrayNros);
                OrdenarArray(arrayNros);
                var promedio = CalcularPromedioDeArray(arrayNros);
                Console.WriteLine("Array de nros. ordenado:");
                ImprimirArray(arrayNros);
                ImprimirPromedio(promedio);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private static void ImprimirArray(int[] arrayNros)
        {
            string arrayConcatenado = "[";
            for (int i = 0; i < arrayNros.Length; i++)
            {
                arrayConcatenado += arrayNros[i].ToString() + ", ";
            }
            arrayConcatenado += "]";
            Console.WriteLine(arrayConcatenado);
        }

        private static void ImprimirPromedio(float promedio)
        {
            Console.WriteLine("Promedio: " + promedio.ToString());
        }

        private static float CalcularPromedioDeArray(int[] arrayNros)
        {
            float totalNros = 0;
            for (int i = 0; i < arrayNros.Length; i++)
            {
                totalNros += arrayNros[i];
            }
            return totalNros / arrayNros.Length;
        }

        private static void OrdenarArray(int[] arrayNros)
        {
            for (int i = 0; i < arrayNros.Length; i++)
            {
                for (int j = 1; j < arrayNros.Length; j++)
                {
                    if (arrayNros[j] > arrayNros[j - 1])
                    {
                        int aux = arrayNros[j];
                        arrayNros[j] = arrayNros[j - 1];
                        arrayNros[j - 1] = aux;
                    }
                }
            }

        }
    }
}
