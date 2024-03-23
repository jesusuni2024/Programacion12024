using System;

class Program
{
    static void Main(string[] args)
    {
        
        int tamaño = 10;
        
        
        int[] multiplos = new int[tamaño];

      
        int[] bases = { 2, 3, 5, 7 }; 

        
        for (int i = 0; i < tamaño; i++)
        {
            multiplos[i] = GenerarMultiplo(i + 1, bases);
        }

       
        Console.WriteLine("Arreglo de Múltiplos:");
        foreach (int multiplo in multiplos)
        {
            Console.Write(multiplo + " ");
        }
    }

    
    static int GenerarMultiplo(int indice, int[] bases)
    {
        int resultado = 0;
        foreach (int baseNum in bases)
        {
            resultado += baseNum * indice;
        }
        return resultado;
    }
}
