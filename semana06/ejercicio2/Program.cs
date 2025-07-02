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

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        Cabeza = anterior;
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}

