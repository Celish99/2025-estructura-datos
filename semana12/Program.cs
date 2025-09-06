using System;
using System.Collections.Generic;

namespace TorneoFutbol
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }

        public Jugador(string nombre, int edad, string posicion)
        {
            Nombre = nombre;
            Edad = edad;
            Posicion = posicion;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Posición: {Posicion}";
        }
    }

    public class Equipo
    {
        public string NombreEquipo { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo(string nombre)
        {
            NombreEquipo = nombre;
            Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public void MostrarJugadores()
        {
            Console.WriteLine($"Equipo: {NombreEquipo}");
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador);
            }
        }
    }

    class Programa
    {
        static void Main()
        {
            Dictionary<string, Equipo> torneo = new Dictionary<string, Equipo>();

            Equipo equipoA = new Equipo("Tigres");
            Equipo equipoB = new Equipo("Leones");

            equipoA.AgregarJugador(new Jugador("Carlos", 22, "Delantero"));
            equipoA.AgregarJugador(new Jugador("Miguel", 25, "Defensa"));
            equipoB.AgregarJugador(new Jugador("Luis", 21, "Portero"));
            equipoB.AgregarJugador(new Jugador("Pedro", 24, "Mediocampista"));

            torneo[equipoA.NombreEquipo] = equipoA;
            torneo[equipoB.NombreEquipo] = equipoB;

            foreach (var equipo in torneo.Values)
            {
                equipo.MostrarJugadores();
                Console.WriteLine();
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            torneo.ContainsKey("Tigres");
            watch.Stop();
            Console.WriteLine($"Tiempo de búsqueda de equipo: {watch.ElapsedTicks} ticks");
        }
    }
}
