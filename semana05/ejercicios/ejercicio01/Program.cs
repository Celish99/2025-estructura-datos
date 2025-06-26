using System;
using System.Collections.Generic;

class ProgramaAsignaturas
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

        // Mostrar cada asignatura con el mensaje
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("Yo estudio " + asignatura);
        }
    }
}
