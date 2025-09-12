using System;
using System.Collections.Generic;

class ProgramaRevistas
{
    // Método principal
    static void Main(string[] args)
    {
        // Crear catálogo de revistas usando una lista
        List<string> catalogo = new List<string>()
        {
            "Revista Ciencia Hoy",
            "Tecnología Avanzada",
            "Mundo de la Naturaleza",
            "Arte y Cultura",
            "Historia Universal",
            "Revista Educativa",
            "Innovación y Sociedad",
            "Deportes al Día",
            "Salud y Bienestar",
            "Viajes y Aventuras"
        };

        int opcion;

        do
        {
            Console.WriteLine("\n--- Catálogo de Revistas ---");
            Console.WriteLine("1. Buscar revista (Iterativa)");
            Console.WriteLine("2. Buscar revista (Recursiva)");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el título a buscar: ");
                    string tituloIterativo = Console.ReadLine();
                    if (BusquedaIterativa(catalogo, tituloIterativo))
                        Console.WriteLine("Encontrado");
                    else
                        Console.WriteLine("No encontrado");
                    break;

                case 2:
                    Console.Write("Ingrese el título a buscar: ");
                    string tituloRecursivo = Console.ReadLine();
                    if (BusquedaRecursiva(catalogo, tituloRecursivo, 0))
                        Console.WriteLine("Encontrado");
                    else
                        Console.WriteLine("No encontrado");
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 3);
    }

    // Método de búsqueda iterativa
    static bool BusquedaIterativa(List<string> catalogo, string titulo)
    {
        foreach (var revista in catalogo)
        {
            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }

    // Método de búsqueda recursiva
    static bool BusquedaRecursiva(List<string> catalogo, string titulo, int indice)
    {
        if (indice >= catalogo.Count)
            return false;

        if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
            return true;

        return BusquedaRecursiva(catalogo, titulo, indice + 1);
    }
}
