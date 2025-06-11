using System;

namespace RegistroEstudiante
{
    // Clase Estudiante
    class Estudiante
    {
        // Atributos privados
        private int id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string[] telefonos;

        // Constructor
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefonos = telefonos;
        }

        // Método para mostrar información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Teléfonos: ");
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {telefonos[i]}");
            }
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear array de teléfonos
            string[] telefonos = new string[3];
            telefonos[0] = "0991234543";
            telefonos[1] = "0987654365";
            telefonos[2] = "0971122735";

            // Crear objeto Estudiante
            Estudiante estudiante = new Estudiante(
                1,
                "Luis",
                "Cuenca",
                "Calle 24 de Mayo y Av. Panamericana",
                telefonos
            );

            // Mostrar información
            estudiante.MostrarInformacion();
        }
    }
}

