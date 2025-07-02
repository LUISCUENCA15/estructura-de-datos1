using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo Cabeza;

    public void Agregar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = Cabeza;
        Cabeza = nuevo;
    }

    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void Buscar(int valor)
    {
        Nodo actual = Cabeza;
        int contador = 0;

        while (actual != null)
        {
            if (actual.Dato == valor)
            {
                contador++;
            }
            actual = actual.Siguiente;
        }

        if (contador > 0)
        {
            Console.WriteLine($"El valor {valor} se encuentra {contador} veces en la lista.");
        }
        else
        {
            Console.WriteLine($"El valor {valor} no fue encontrado en la lista.");
        }
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(5);
        lista.Agregar(10);
        lista.Agregar(15);
        lista.Agregar(10);
        lista.Agregar(20);

        Console.WriteLine("Lista:");
        lista.Mostrar();

        Console.Write("Ingrese el valor que desea buscar: ");
        int valor = int.Parse(Console.ReadLine());

        lista.Buscar(valor);
    }
}
