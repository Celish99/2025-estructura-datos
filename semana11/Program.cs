using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Traductor
{
    static void Main()
    {
        // Diccionario inicial
        var dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time","tiempo"},{"person","persona"},{"year","año"},{"way","camino / forma"},
            {"day","día"},{"thing","cosa"},{"man","hombre"},{"world","mundo"},{"life","vida"},
            {"hand","mano"},{"part","parte"},{"child","niño/a"},{"eye","ojo"},{"woman","mujer"},
            {"place","lugar"},{"work","trabajo"},{"week","semana"},{"case","caso"},
            {"point","punto / tema"},{"government","gobierno"},{"company","empresa / compañía"}
        };

        int opcion;
        do
        {
            Console.WriteLine("\n==== MENÚ ====\n1. Traducir frase\n2. Agregar palabra\n0. Salir");
            Console.Write("Seleccione opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) Traducir(dic);
            else if (opcion == 2) Agregar(dic);

        } while (opcion != 0);
    }

    static void Traducir(Dictionary<string,string> dic)
    {
        Console.Write("\nFrase: ");
        string[] palabras = Console.ReadLine().Split(' ');
        for (int i=0;i<palabras.Length;i++)
        {
            string limpia = Regex.Replace(palabras[i], @"[\p{P}]", "");
            string signo = palabras[i].Replace(limpia, "");
            if (dic.ContainsKey(limpia.ToLower()))
                palabras[i] = dic[limpia.ToLower()] + signo;
        }
        Console.WriteLine("Traducción: " + string.Join(" ", palabras));
    }

    static void Agregar(Dictionary<string,string> dic)
    {
        Console.Write("\nInglés: "); string eng = Console.ReadLine().ToLower();
        Console.Write("Español: "); string esp = Console.ReadLine();
        dic[eng] = esp;
        Console.WriteLine("✔ Palabra agregada.");
    }
}
