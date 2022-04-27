using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escribir el método 

Int Ocurrencias(int buscado, arreglo int[])

Que devuelva la cantidad de ocurrencias de “buscado” en “arreglo” 
*/
/*
 Escribir un programa en C# que obtenga e imprima a partir de un arreglo de enteros la cantidad de veces que aparece cada elemento usando un asterisco para contar cada aparición del elemento. 
En el resultado, los elementos deben estar ordenados de menor a mayor. 
Para el ejercicio considerar elementos entre el 1 y el 9.
Por ejemplo, para el arreglo: 
int[] myArray = int[] { 8,1,6,7,8,4,9,8,2 }; el resultado se vería así:

1: *
2: *
3:
4: *
5: 
6: *
7: *
8: **
9: *
*/
namespace Resolucion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 9, 8, 2 ,3,1,9,4,1,6,5};
            var arrayOrdenado = OrdenarArrayAsc(myArray);
            int tamañoArray = arrayOrdenado.Length;
            for (int i = 1; i < tamañoArray; i++)
            {
                Console.Write("\n" + arrayOrdenado[i - 1].ToString() + ": ");
                Console.Write("*");                
                while (i < tamañoArray && arrayOrdenado[i - 1] == arrayOrdenado[i])
                {                    
                    Console.Write(" *");
                    i++;
                }
            }
            Console.ReadLine();
        }
        private static int[] OrdenarArrayAsc(int[] myArray)
        {
            var arrayOrdenado = myArray;
            for (int i = 0; i < arrayOrdenado.Length; i++)
            {
                for (int j = 1; j < arrayOrdenado.Length; j++)
                {
                    if (arrayOrdenado[j - 1] > arrayOrdenado[j])
                    {
                        int aux = arrayOrdenado[j - 1];
                        arrayOrdenado[j - 1] = arrayOrdenado[j];
                        arrayOrdenado[j] = aux;
                    }
                }
            }
            return arrayOrdenado;
        }

        private static int[] CopiarArrayExceptoNro(int primerNro, int[] arrayOrdenado)
        {
            int ocurrenciasNro = Ocurrencias(primerNro, arrayOrdenado);
            int tamañoNuevoArray = arrayOrdenado.Length - ocurrenciasNro;
            int[] arrayNuevo = new int[tamañoNuevoArray];
            int j = 0;
            for (int i = tamañoNuevoArray - 1; i < arrayOrdenado.Length; i++)
            {
                if (arrayNuevo.Length > 0)
                {
                    arrayNuevo[j] = arrayOrdenado[i];
                    j++;
                }
            }
            return arrayNuevo;

        }

        

        private static void ImprimirOcurrencias(int[] myArray)
        {

            Console.WriteLine(myArray.Max().ToString());
            Console.ReadLine();
        }

        public static int Ocurrencias(int buscado, int[] arreglo)
        {
            int contador = 0;
            for(int i=0; i<arreglo.Length; i++)
            {
                if (arreglo[i] == buscado)
                {
                    contador++;
                }
            }
            return contador;
        }

    }
}
