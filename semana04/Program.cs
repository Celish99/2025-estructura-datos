using System;
using System.Collections.Generic;

namespace AgendaSimple
{
    // Clase Contacto: nombre y número de teléfono
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Contacto(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre} - Teléfono: {Numero}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Contacto> agenda = new List<Contacto>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=== AGENDA SIMPLE ===");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Ver contactos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese número de teléfono: ");
                        string numero = Console.ReadLine();
                        agenda.Add(new Contacto(nombre, numero));
                        Console.WriteLine("Contacto agregado.");
                        break;

                    case "2":
                        Console.WriteLine("\n--- Contactos Registrados ---");
                        if (agenda.Count == 0)
                        {
                            Console.WriteLine("No hay contactos.");
                        }
                        else
                        {
                            foreach (Contacto c in agenda)
                            {
                                c.Mostrar();
                            }
                        }
                        break;

                    case "3":
                        continuar = false;
                        Console.WriteLine("Saliendo de la agenda...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
 