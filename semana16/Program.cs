using System;
using System.Collections.Generic;

class Grafo
{
    private Dictionary<string, List<string>> adyacencia = new Dictionary<string, List<string>>();

    public void AgregarArista(string origen, string destino, bool dirigido = false)
    {
        if (!adyacencia.ContainsKey(origen)) adyacencia[origen] = new List<string>();
        adyacencia[origen].Add(destino);
        if (!dirigido)
        {
            if (!adyacencia.ContainsKey(destino)) adyacencia[destino] = new List<string>();
            adyacencia[destino].Add(origen);
        }
    }

    public void MostrarGrafo()
    {
        foreach (var nodo in adyacencia)
        {
            Console.Write($"{nodo.Key}: ");
            Console.WriteLine(string.Join(", ", nodo.Value));
        }
    }

    public void CentralidadGrado()
    {
        Console.WriteLine("\nCentralidad de grado:");
        foreach (var nodo in adyacencia)
        {
            Console.WriteLine($"{nodo.Key}: {nodo.Value.Count}");
        }
    }
}

class Program
{
    static void Main()
    {
        Grafo grafo = new Grafo();

        // Ejemplo 1 (no dirigido)
        grafo.AgregarArista("A", "B");
        grafo.AgregarArista("A", "C");
        grafo.AgregarArista("B", "C");
        grafo.AgregarArista("C", "D");
        grafo.AgregarArista("D", "E");

        Console.WriteLine("Grafo ejemplo 1:");
        grafo.MostrarGrafo();
        grafo.CentralidadGrado();

        // Ejemplo 2 (dirigido)
        Grafo grafoDirigido = new Grafo();
        grafoDirigido.AgregarArista("1", "2", true);
        grafoDirigido.AgregarArista("2", "3", true);
        grafoDirigido.AgregarArista("2", "4", true);
        grafoDirigido.AgregarArista("4", "5", true);

        Console.WriteLine("\nGrafo ejemplo 2 (dirigido):");
        grafoDirigido.MostrarGrafo();
        grafoDirigido.CentralidadGrado();
    }
}
