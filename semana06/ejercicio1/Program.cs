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

    // Función para invertir la lista enlazada
    public void Invertir()
    {
        Nodo previo = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.siguiente;
            actual.siguiente = previo;
            previo = actual;
            actual = siguiente;
        }

        cabeza = previo;
    }

    // Mostrar los elementos de la lista
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
        lista.Agregar(1);
        lista.Agregar(2);
        lista.Agregar(3);
        lista.Agregar(4);

        Console.WriteLine("Lista original:");
        lista.MostrarLista();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.MostrarLista();
    }
}

