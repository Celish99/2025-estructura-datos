using System;
using System.Collections.Generic;
using System.Linq;

namespace VacunacionCovid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generar 500 ciudadanos ficticios
            HashSet<string> ciudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add("Ciudadano " + i);
            }

            // Conjunto de vacunados con Pfizer (75)
            HashSet<string> pfizer = new HashSet<string>();
            for (int i = 1; i <= 75; i++)
            {
                pfizer.Add("Ciudadano " + i);
            }

            // Conjunto de vacunados con AstraZeneca (75)
            HashSet<string> astraZeneca = new HashSet<string>();
            for (int i = 50; i < 125; i++) // se sobreponen algunos para simular doble dosis
            {
                astraZeneca.Add("Ciudadano " + i);
            }

            // Ciudadanos que no se han vacunado
            var noVacunados = ciudadanos.Except(pfizer.Union(astraZeneca));

            // Ciudadanos que han recibido ambas dosis (Pfizer y AstraZeneca)
            var ambasDosis = pfizer.Intersect(astraZeneca);

            // Ciudadanos que solo recibieron Pfizer
            var soloPfizer = pfizer.Except(astraZeneca);

            // Ciudadanos que solo recibieron AstraZeneca
            var soloAstra = astraZeneca.Except(pfizer);

            // Mostrar resultados
            Console.WriteLine("===== LISTADOS DE VACUNACIÓN COVID =====\n");

            Console.WriteLine("No vacunados:");
            foreach (var c in noVacunados) Console.WriteLine(c);

            Console.WriteLine("\nAmbas dosis:");
            foreach (var c in ambasDosis) Console.WriteLine(c);

            Console.WriteLine("\nSolo Pfizer:");
            foreach (var c in soloPfizer) Console.WriteLine(c);

            Console.WriteLine("\nSolo AstraZeneca:");
            foreach (var c in soloAstra) Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
