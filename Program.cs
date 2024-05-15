using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola! ¿Cuál es tu nombre?");
            string nombre = Console.ReadLine(); // Pedir al usuario que ingrese su nombre

            // Mostrar un saludo utilizando el nombre ingresado
            Console.WriteLine($"¡Hola, {nombre}! Bienvenido.");

            Lista lista = new Lista();

            int valor, n;
            Console.WriteLine("Ingrese la cantidad de elementos que tendra la lista");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Elementos " + i);
                valor = int.Parse(Console.ReadLine());
                lista.agregar(valor);
            }
            lista.mostrar();
            int suma = lista.sumar();
            Console.WriteLine("La suma de los elementos de la lista es: " + suma);

            Console.WriteLine("Adios");
            // Esperar a que el usuario presione una tecla antes de cerrar la aplicación
            Console.WriteLine("Presiona cualquier tecla para salir...");

            Console.ReadKey();
        }
    }
}
