using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Ordenar_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo para guardar los 10 números
            int[] numeros = new int[10];

            // Pedir los números al usuario y guardarlos en el arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digita el número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Ordenar los números
            Array.Sort(numeros);

            // Mostrar los números ordenados
            Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
