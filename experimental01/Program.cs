using System;
using System.Collections.Generic;

public class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public Contacto(string nombre, string telefono, string correo)
    {
        Nombre = nombre;
        Telefono = telefono;
        Correo = correo;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Teléfono: {Telefono}, Correo: {Correo}";
    }
}

public class AgendaTelefonica
{
    private List<Contacto> contactos = new List<Contacto>();

    public void AgregarContacto(string nombre, string telefono, string correo)
    {
        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo))
        {
            Console.WriteLine("Todos los campos son obligatorios.");
            return;
        }

        contactos.Add(new Contacto(nombre, telefono, correo));
        Console.WriteLine("✅ Contacto agregado exitosamente.");
    }

    public void MostrarContactos()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine("📭 La agenda está vacía.");
        }
        else
        {
            Console.WriteLine("📒 Contactos en la agenda:");
            foreach (var c in contactos)
            {
                Console.WriteLine(c);
            }
        }
    }

    public void BuscarContacto(string nombre)
    {
        var encontrados = contactos.FindAll(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (encontrados.Count > 0)
        {
            Console.WriteLine($"🔍 Contactos encontrados con el nombre \"{nombre}\":");
            foreach (var c in encontrados)
            {
                Console.WriteLine(c);
            }
        }
        else
        {
            Console.WriteLine("❌ No se encontró el contacto.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Para acentos y símbolos
        AgendaTelefonica agenda = new AgendaTelefonica();

        while (true)
        {
            Console.WriteLine("\n📱 MENÚ DE AGENDA TELEFÓNICA");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine();
                    Console.Write("Correo: ");
                    string correo = Console.ReadLine();
                    agenda.AgregarContacto(nombre, telefono, correo);
                    break;

                case "2":
                    agenda.MostrarContactos();
                    break;

                case "3":
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    agenda.BuscarContacto(buscar);
                    break;

                case "4":
                    Console.WriteLine("👋 Saliendo de la agenda. ¡Hasta pronto!");
                    return;

                default:
                    Console.WriteLine("⚠️ Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}

