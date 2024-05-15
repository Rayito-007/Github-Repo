using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Repo
{
    internal class Lista
    {
        private Nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        public void agregar(int valor)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.valor = valor;
            nuevo.siguiente = inicio;
            inicio = nuevo;
        }

        public void mostrar()
        {
            Nodo actual = inicio;
            Console.WriteLine("Elementos de la lista");
            while (actual != null)
            {
                Console.WriteLine(actual.valor);
                actual = actual.siguiente;
            }
        }

        public int sumar()
        {
            int suma = 0;
            Nodo actual = inicio;
            while (actual != null)
            {
                suma += actual.valor;
                actual = actual.siguiente;
            }
            return suma;
        }
    }
}
