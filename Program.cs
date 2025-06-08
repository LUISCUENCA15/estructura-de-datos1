using System;

namespace FigurasGeometricas
{
    // La clase Circulo representa un círculo y permite calcular su área y perímetro
    public class Circulo
    {
        // Atributo privado que guarda el radio del círculo
        private double radio;

        // Constructor que recibe el radio como parámetro
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área de un círculo: π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro de un círculo: 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // La clase Rectangulo representa un rectángulo y permite calcular su área y perímetro
    public class Rectangulo
    {
        // Atributos privados que guardan la base y altura del rectángulo
        private double baseRectangulo;
        private double altura;

        // Constructor que recibe base y altura como parámetros
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Método para calcular el área de un rectángulo: base * altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // Método para calcular el perímetro de un rectángulo: 2 * (base + altura)
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    // Clase principal para ejecutar el programa
    class Programa
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Circulo con radio 5
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + circulo.CalcularPerimetro());

            // Crear un objeto de tipo Rectangulo con base 4 y altura 6
            Rectangulo rectangulo = new Rectangulo(4, 6);
            Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + rectangulo.CalcularPerimetro());
        }
    }
}

