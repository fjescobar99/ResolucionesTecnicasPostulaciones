using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoC
{
    /*c) Realizar una aplicación de consola que lanza 50 veces el dado y devuelve la cantidad de 
        veces que salió cada número, ordenado de menor a mayor por cantidad de apariciones de los 
        nros.
        */
    class Program
    {
        static void Main(string[] args)
        {
            var array = TirarDados();
            var diccionarioPorApariciones = GetResultadosDeApariciones(array);
            ImprimirResultados(diccionarioPorApariciones);
            Console.ReadLine();
        }

        private static void ImprimirResultados(Dictionary<int, int> diccionarioPorApariciones)
        {
            Console.WriteLine("Resultados:");
            foreach (var item in diccionarioPorApariciones)
            {
                Console.WriteLine($"Dado nro {item.Key.ToString()}: {item.Value.ToString()} apariciones.");
            }
        }

        private static Dictionary<int, int> GetResultadosDeApariciones(int[] array)
        {
            var diccionarioApariciones = new Dictionary<int, int>();
            for(int i = 1; i<=6; i++)
            {
                diccionarioApariciones.Add(i, GetApariciones(i, array));                
            }
            
            return OrdenarDiccionarioDesc(diccionarioApariciones);
        }

        private static Dictionary<int, int> OrdenarDiccionarioDesc(Dictionary<int, int> diccionarioApariciones)
        {
            return diccionarioApariciones.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
        
        
        private static int GetApariciones(int nroABuscar, int[] array)
        {
            int apariciones = 0;
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] == nroABuscar)
                {
                    apariciones++;
                }
            }
            return apariciones;
        }

        private static int[] TirarDados()
        {
            var array = new int[50];
            var random = new Random();
            for (int i = 0; i < 50; i++)
            {
                array[i] = random.Next(1, 7);
            }
            return array;
        }
    }
}
