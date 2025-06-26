using System;
using System.Collections.Generic;

class LoteriaPrimitiva
{
    static void Main()
    {
        // Lista para almacenar los números ganadores
        List<int> numerosGanadores = new List<int>();

        Console.WriteLine("Ingrese los 6 números ganadores de la lotería primitiva:");

        while (numerosGanadores.Count < 6)
        {
            Console.Write($"Número {numerosGanadores.Count + 1}: ");
            string entrada = Console.ReadLine();

            // Validar si es número válido entre 1 y 49
            if (int.TryParse(entrada, out int numero) && numero >= 1 && numero <= 49)
            {
                if (!numerosGanadores.Contains(numero))
                {
                    numerosGanadores.Add(numero);
                }
                else
                {
                    Console.WriteLine("Ese número ya ha sido ingresado. Intenta con otro.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido entre 1 y 49.");
            }
        }

        // Ordenar los números
        numerosGanadores.Sort();

        // Mostrar el resultado
        Console.WriteLine("\nNúmeros ganadores ordenados:");
        foreach (int numero in numerosGanadores)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine(); // Salto de línea final
    }
}
