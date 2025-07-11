using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    // Declaramos las tres pilas que representan las torres
    static Stack<int> torreA = new Stack<int>();
    static Stack<int> torreB = new Stack<int>();
    static Stack<int> torreC = new Stack<int>();

    static void Main()
    {
        Console.WriteLine("Ingrese el número de discos:");
        int n = int.Parse(Console.ReadLine());

        // Inicializar la torre A con los discos (el más grande abajo)
        for (int i = n; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("\n--- Resolviendo Torres de Hanoi ---\n");
        MostrarTorres();
        Hanoi(n, torreA, torreC, torreB, "A", "C", "B");
    }

    /// <summary>
    /// Algoritmo recursivo para resolver Torres de Hanoi.
    /// </summary>
    static void Hanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            MostrarTorres();
        }
        else
        {
            Hanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
            MoverDisco(origen, destino, nombreOrigen, nombreDestino);
            MostrarTorres();
            Hanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }

    /// <summary>
    /// Mueve un disco entre dos torres y muestra el movimiento.
    /// </summary>
    static void MoverDisco(Stack<int> origen, Stack<int> destino, string nombreOrigen, string nombreDestino)
    {
        int disco = origen.Pop();
        destino.Push(disco);
        Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
    }

    /// <summary>
    /// Muestra el estado actual de cada torre.
    /// </summary>
    static void MostrarTorres()
    {
        Console.WriteLine("Torre A: " + string.Join(", ", torreA.ToArray()));
        Console.WriteLine("Torre B: " + string.Join(", ", torreB.ToArray()));
        Console.WriteLine("Torre C: " + string.Join(", ", torreC.ToArray()));
        Console.WriteLine("-------------------------------\n");
    }
}
