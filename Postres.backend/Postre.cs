using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postres.backend
{
    internal class Ingredientes
    {
        public string ingrediente { get; set; }

        private LinkedList<string> listaIngredientes = new LinkedList<string>();

        public void DefinirIngrediente()
        {
            Console.WriteLine("Agregue ingrediente");
            ingrediente = Console.ReadLine();
            Agregar();
        }

        private void Agregar()
        {
            listaIngredientes.AddFirst(ingrediente);
        }
        public void Imprimir()
        {
            foreach (string item in listaIngredientes)
            {
                Console.WriteLine(item);
            }
        }

        public void Eliminar()
        {
            Console.WriteLine("ingrese valor a eliminar");
            ingrediente = Console.ReadLine();


            bool found = false; // *********

            LinkedListNode<string> nodoActual = listaIngredientes.First;

            while (nodoActual != null)
            {
                if (nodoActual.Value == ingrediente)
                {
                    listaIngredientes.Remove(nodoActual);
                    break;
                }
                nodoActual = nodoActual.Next;
            }
            // *******
            if (!found)
            {
                Console.WriteLine($"El valor '{ingrediente}' ha sido eliminado ");

            }
            else
            {
                Console.WriteLine($"El valor '{ingrediente}' no se encontró en la lista");
            }

            Console.WriteLine("Lista actualizada:");
            foreach (string value in listaIngredientes)
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }
    }
}
