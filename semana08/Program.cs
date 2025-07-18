using System;
using System.Collections.Generic;
using System.Threading;

namespace CongresoAuditorio
{
    class Asistente
    {
        public string Nombre { get; set; }
        public int AsientoAsignado { get; set; }
    }

    class Auditorio
    {
        private int totalAsientos = 100;
        private int asientoActual = 1;
        private object bloqueo = new object();
        public List<Asistente> ListaAsistentes = new List<Asistente>();

        public bool AsignarAsiento(Asistente asistente)
        {
            lock (bloqueo)
            {
                if (asientoActual > totalAsientos)
                    return false;

                asistente.AsientoAsignado = asientoActual++;
                ListaAsistentes.Add(asistente);
                return true;
            }
        }

        public void Reporte()
        {
            Console.WriteLine("\n--- Reporte de Asistentes ---");
            foreach (var a in ListaAsistentes)
                Console.WriteLine($"Nombre: {a.Nombre}, Asiento: {a.AsientoAsignado}");
        }
    }

    class Registrador
    {
        private Queue<string> fila;
        private Auditorio auditorio;

        public Registrador(Queue<string> fila, Auditorio auditorio)
        {
            this.fila = fila;
            this.auditorio = auditorio;
        }

        public void Procesar()
        {
            while (fila.Count > 0)
            {
                string nombre = fila.Dequeue();
                Asistente a = new Asistente { Nombre = nombre };

                if (auditorio.AsignarAsiento(a))
                {
                    Console.WriteLine($"Registrado: {a.Nombre} -> Asiento {a.AsientoAsignado}");
                    Thread.Sleep(50); // Simula tiempo de registro
                }
            }
        }
    }

    class Programa
    {
        static void Main()
        {
            Queue<string> fila1 = new Queue<string>();
            Queue<string> fila2 = new Queue<string>();

            // Simulamos 50 personas en cada fila
            for (int i = 1; i <= 50; i++)
            {
                fila1.Enqueue($"Persona_{i}");
                fila2.Enqueue($"Persona_{i + 50}");
            }

            Auditorio auditorio = new Auditorio();

            Registrador r1 = new Registrador(fila1, auditorio);
            Registrador r2 = new Registrador(fila2, auditorio);

            Thread t1 = new Thread(new ThreadStart(r1.Procesar));
            Thread t2 = new Thread(new ThreadStart(r2.Procesar));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            auditorio.Reporte();
        }
    }
}
