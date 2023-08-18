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

        List<string> nombrePostre = new List<string>();
        public string nombre { get; set; }

        string opcion = "";

        public void OpcionesPostre()
        {
            do
            {
                Console.WriteLine("1. Agregar postres e ingredientes");
                Console.WriteLine("2. Consultar postres");
                Console.WriteLine("3. Eliminar postres");

                opcion = Console.ReadLine();
                switch (opcion)
                {

                    case "1": // agrega postres e ingredientes
                        Console.WriteLine("Ingrese el nombre del postre (o escriba 'salir' para terminar):");

                        nombre = Console.ReadLine();

                        if (nombre.ToLower() == "salir")
                            break;

                        LinkedList<string> ingredientes = new LinkedList<string>();

                        nombrePostre.Add(nombre);

                        while (true)
                        {
                            Console.WriteLine("Ingrese un ingrediente para el postre (o escriba 'fin' para terminar):");
                            string ingrediente = Console.ReadLine();
                            Console.Clear();

                            if (ingrediente.ToLower() == "fin")
                                break;

                            ingredientes.AddLast(ingrediente);
                        }

                        postres.Add(ingredientes);  menu(); break;

                    case "2": // consultar postres

                        Console.WriteLine("\nLista de postres y sus ingredientes:");

                        for (int i = 0; i < postres.Count; i++)
                        {
                            Console.WriteLine(nombrePostre[i]);
                            foreach (var ingrediente in postres[i])
                            {
                                Console.WriteLine("- " + ingrediente);
                            }
                            Console.WriteLine();

                        }
                        Console.ReadKey(); menu(); break;

                    case "3": // eliminar postre

                        Console.WriteLine("ingrese el postre a eliminar");
                        string eliminar = Console.ReadLine();

                        for (int i = 0; i < postres.Count; i++)
                        {
                            foreach (var postre in nombrePostre[i])
                            {
                                if (eliminar == nombrePostre[i])
                                {
                                    nombrePostre.RemoveAt(i);
                                    postres.RemoveAt(i);
                                }
                            }
                        } menu(); break;
                }
            } while (true);
        }

        public void menu()
        {
            Console.WriteLine("1. Agregar postres e ingredientes");
            Console.WriteLine("2. Consultar postres");
            Console.WriteLine("3. Eliminar postres");

            opcion = Console.ReadLine();

            OpcionesPostre();
        }
    }
}
