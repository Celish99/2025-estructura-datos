using System;
using System.Collections.Generic;
using System.Globalization;

class ProgramaNotas
{
    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };

        // Diccionario para guardar las notas
        Dictionary<string, double> notas = new Dictionary<string, double>();

        // Pedir al usuario la nota de cada asignatura
        foreach (string asignatura in asignaturas)
        {
            double nota;
            while (true)
            {
                Console.Write($"¿Qué nota has sacado en {asignatura}? (0 - 10): ");
                string entrada = Console.ReadLine();

                // Intentar convertir la entrada a double
                if (double.TryParse(entrada, NumberStyles.Number, CultureInfo.InvariantCulture, out nota) && nota >= 0 && nota <= 10)
                {
                    notas[asignatura] = nota;
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa una nota válida entre 0 y 10.");
                }
            }
        }

        // Mostrar el resumen de notas
        Console.WriteLine("\n--- Resumen de tus notas ---");
        foreach (var par in notas)
        {
            Console.WriteLine($"En {par.Key} has sacado {par.Value:F1}");
        }
    }
}
