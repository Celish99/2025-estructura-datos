// Archivo: Estudiante.cs

using System;

namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    public class Estudiante
    {
        // Atributos del estudiante
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }  // Array para almacenar los teléfonos

        // Constructor de la clase
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            foreach (string telefono in Telefonos)
            {
                Console.WriteLine($"- {telefono}");
            }
        }
    }

    // Clase principal para probar la clase Estudiante
    class Program
    {
        static void Main(string[] args)
        {
            // Crear array de teléfonos (3 teléfonos iguales)
            string[] telefonos = new string[3] { "0959403401", "0959403401", "0959403401" };

            // Crear objeto Estudiante con los datos de Mar
