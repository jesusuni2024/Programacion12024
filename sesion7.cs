using System;

public class Calculadora
{
        protected string Marca;
    protected string Serie;

    
    public Calculadora(string marca, string serie)
    {
        Marca = marca;
        Serie = serie;
    }

    
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return double.NaN; 
        }
        return a / b;
    }
}

public class CalculadoraCientifica : Calculadora
{
    
    public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
    {
    }

    
    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Raiz(double a)
    {
        return Math.Sqrt(a);
    }

    public double Modulo(double a, double b)
    {
        return a % b;
    }

    public double Logaritmo(double a, double b)
    {
        return Math.Log(a, b);
    }
}

class Program
{
    static void Main(string[] args)
    {
    
        Calculadora miCalculadora = new Calculadora("Casio", "12345");

        
        Console.WriteLine("Suma: " + miCalculadora.Sumar(5, 3));
        Console.WriteLine("Resta: " + miCalculadora.Restar(5, 3));
        Console.WriteLine("Multiplicación: " + miCalculadora.Multiplicar(5, 3));
        Console.WriteLine("División: " + miCalculadora.Dividir(5, 3));

        Console.WriteLine();

    
        CalculadoraCientifica miCalculadoraCientifica = new CalculadoraCientifica("HP", "7890");

        
        Console.WriteLine("Potencia: " + miCalculadoraCientifica.Potencia(2, 3));
        Console.WriteLine("Raíz cuadrada: " + miCalculadoraCientifica.Raiz(25));
        Console.WriteLine("Módulo: " + miCalculadoraCientifica.Modulo(10, 3));
        Console.WriteLine("Logaritmo: " + miCalculadoraCientifica.Logaritmo(100, 10));
    }
}
