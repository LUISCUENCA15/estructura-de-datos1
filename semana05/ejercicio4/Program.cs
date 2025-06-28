using System;
using System.Collections.Generic;

class Loteria
{
    public List<int> Numeros { get; set; }

    public Loteria()
    {
        Numeros = new List<int>();
    }

    public void PedirNumeros()
    {
        Console.WriteLine("Ingresa 6 números ganadores de la lotería:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Numeros.Add(numero);
        }
    }

    public void MostrarOrdenados()
    {
        Numeros.Sort();
        Console.WriteLine("Números ordenados: " + string.Join(", ", Numeros));
    }
}

class Program
{
    static void Main()
    {
        Loteria loteria = new Loteria();
        loteria.PedirNumeros();
        loteria.MostrarOrdenados();
    }
}

