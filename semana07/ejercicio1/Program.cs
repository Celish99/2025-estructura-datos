using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Verifica si una expresión tiene los paréntesis, llaves y corchetes balanceados.
    /// </summary>
    /// <param name="expresion">Cadena con la expresión matemática</param>
    /// <returns>True si está balanceada, false en caso contrario</returns>
    static bool EstaBalanceada(string expresion)
    {
        // Pila para almacenar los caracteres de apertura
        Stack<char> pila = new Stack<char>();

        // Recorrer cada caracter de la expresión
        foreach (char c in expresion)
        {
            // Si es un símbolo de apertura, se añade a la pila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es un símbolo de cierre, se verifica correspondencia con el tope de la pila
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no hay apertura correspondiente
                if (pila.Count == 0)
                {
                    return false;
                }

                char ultimo = pila.Pop();

                // Verifica que el símbolo de cierre corresponda con el de apertura
                if (!EsPareja(ultimo, c))
                {
                    return false;
                }
            }
        }

        // Si al final la pila está vacía, todo está balanceado
        return pila.Count == 0;
    }

    /// <summary>
    /// Verifica si un símbolo de apertura y cierre forman pareja
    /// </summary>
    /// <param name="apertura">Carácter de apertura</param>
    /// <param name="cierre">Carácter de cierre</param>
    /// <returns>True si son pareja correcta, false si no</returns>
    static bool EsPareja(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la expresión matemática:");
        string expresion = Console.ReadLine();

        bool resultado = EstaBalanceada(expresion);

        if (resultado)
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula no balanceada.");
        }
    }
}
