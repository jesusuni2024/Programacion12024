
using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Calculadora 

{
    static void Main (string[] args)

    {
        while (true)
        {
            Console.WriteLine("Menu de calculadora");
            Console.WriteLine("1. sum");
            Console.WriteLine("Resta");
            Console.WriteLine("Multiplicacion");
            Console.WriteLine("Division");
            Console.WriteLine("Raiz cuadrada");
            Console.WriteLine("cos");
            Console.WriteLine("Sen");
            Console.WriteLine("Tan");

            Console.Write("Selecciona la opcion");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0; 
            switch (choice)
            {
                case 1:
                    result = Sum();
                    break; 
                case 2:
                    result = Subtract();
                    break;
                case 3: 
                    result = IMultiplyOperators ()
                    break;
                case 4: 
                    result = Divide();
                    break;
                case 5:
                    result = IPowerFunctions();

                     

            }
}