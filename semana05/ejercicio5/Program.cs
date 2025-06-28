using System;
using System.Collections.Generic;

class Numeros
{
    public List<int> Lista { get; set; }

    public Numeros()
    {
        Lista = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            Lista.Add(i);
        }
    }

    public void MostrarInverso()
    {
        Lista.Reverse();
        Console.WriteLine("Números en orden inverso: " + string.Join(", ", Lista));
    }
}

class Program
{
    static void Main()
    {
        Numeros numeros = new Numeros();
        numeros.MostrarInverso();
    }
}

