using System;

public class Nodo
{
    public int valor;
    public Nodo siguiente;

    public Nodo(int valor)
    {
        this.valor = valor;
        siguiente = null;
    }
}

public class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Método para agregar un elemento al final
    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevoNodo;
        }
    }

    // Método de búsqueda que cuenta cuántas veces aparece un valor en la lista
    public void Buscar(int valor)
    {
        Nodo actual = cabeza;
        int contador = 0;

        while (actual != null)
        {
            if (actual.valor == valor)
            {
                contador++;
            }
            actual = actual.siguiente;
        }

        if (contador > 0)
        {
            Console.WriteLine($"El valor {valor} se encuentra {contador} vez/veces en la lista.");
        }
        else
        {
            Console.WriteLine($"El valor {valor} no fue encontrado en la lista.");
        }
    }

    // Método para mostrar los elementos de la lista
    public void MostrarLista()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.valor + " ");
            actual = actual.siguiente;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(20);
        lista.Agregar(10);
        lista.Agregar(10);

        Console.WriteLine("Lista de elementos:");
        lista.MostrarLista();

        // Probar la búsqueda de un número
        lista.Buscar(10); // Debería encontrar el 10 3 veces
        lista.Buscar(20); // Debería encontrar el 20 2 veces
        lista.Buscar(40); // No debería encontrar el 40
    }
}
