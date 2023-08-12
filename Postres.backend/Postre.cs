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
        
        // need to check this code.
        List<string> nombrePostre = new List<string>();  /* */
        public string nombre {get; set;}
        
        public void AgregarPostre()
        {
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del postre (o escriba 'salir' para terminar):");
                /* string nombre = Console.ReadLine(); */
                nombre = Console.ReadLine();

                if (nombre.ToLower() == "salir")
                    break;

                LinkedList<string> ingredientes = new LinkedList<string>();

                nombrePostre.Add(nombre); /* */ 

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
                /* los datos en las listas nombrePostre e ingredientes van de la mano y
                los valores comparten el mismo indice. Hay que ejecutar y doublecheck since I'm coding literally on github */
                    
                Console.WriteLine(nombrePostre[i]); // imprime el nombre del postre
                foreach (var ingrediente in postres[i]) // imprime los ingredientes del postre.
                {
                    Console.WriteLine("- " + ingrediente);
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
