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

            // Esperar a que el usuario presione una tecla antes de cerrar la aplicación
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
