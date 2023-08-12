using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postres.backend
{
    public class Postres
    {
        List<LinkedList<string>> postres = new List<LinkedList<string>>();
        public void AgregarPostre()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del postre (o escriba 'salir' para terminar):");
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "salir")
                    break;

                LinkedList<string> ingredientes = new LinkedList<string>();

                while (true)
                {
                    Console.WriteLine("Ingrese un ingrediente para el postre (o escriba 'fin' para terminar):");
                    string ingrediente = Console.ReadLine();
                    Console.Clear();

                    if (ingrediente.ToLower() == "fin")
                        break;

                    ingredientes.AddLast(ingrediente);
                }

                postres.Add(ingredientes);
            }
        }

        public void Consultar()
        {
            Console.WriteLine("\nLista de postres y sus ingredientes:");

            for (int i = 0; i < postres.Count; i++)
            {
                Console.WriteLine($"Postre {i + 1}:");
                foreach (var ingrediente in postres[i])
                {
                    Console.WriteLine("- " + ingrediente);
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
