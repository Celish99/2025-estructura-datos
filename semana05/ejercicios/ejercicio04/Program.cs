using System;
using System.Collections.Generic;

class NumerosInversos
{
    static void Main()
    {
        // Crear lista con los números del 1 al 10
        List<int> numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Invertir el orden de la lista
        numeros.Reverse();

        // Mostrar los números separados por comas
        Console.WriteLine("Números en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}

