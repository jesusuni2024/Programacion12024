using System;

class Program
{
    static double saldo = 1000; // Saldo inicial

    static void Main(string[] args)
    {
        while (true)
        {
            MostrarMenu();

            Console.WriteLine("\nIngrese su opción:");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ConsultarSaldo();
                    break;
                case 2:
                    Retirar();
                    break;
                case 3:
                    Depositar();
                    break;
                case 4:
                    Console.WriteLine("Gracias por utilizar nuestro cajero automático. ¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nBienvenido al Cajero Automático");
        Console.WriteLine("1. Consultar Saldo");
        Console.WriteLine("2. Retirar");
        Console.WriteLine("3. Depositar");
        Console.WriteLine("4. Salir");
    }

    static void ConsultarSaldo()
    {
        Console.WriteLine($"\nSu saldo actual es: {saldo}");
    }

    static void Retirar()
    {
        Console.WriteLine("\nIngrese la cantidad que desea retirar:");
        double cantidad = double.Parse(Console.ReadLine());

        if (cantidad > saldo)
        {
            Console.WriteLine("No tiene suficiente saldo para realizar esta transacción.");
        }
        else
        {
            saldo -= cantidad;
            Console.WriteLine($"Retiro exitoso. Su saldo actual es: {saldo}");
        }
    }

    static void Depositar()
    {
        Console.WriteLine("\nIngrese la cantidad que desea depositar:");
        double cantidad = double.Parse(Console.ReadLine());

        saldo += cantidad;
        Console.WriteLine($"Depósito exitoso. Su saldo actual es: {saldo}");
    }
}
