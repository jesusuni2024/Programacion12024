using System;  
private static double saldo = 0; 
static void Main()
{ 
    int opcion; 
    do
    { 
        Console.WriteLine ("1 verificar el saldo que tiene disponible"); 
        Console.WriteLine ("2. depositar la cantidad de pisto a la cuenta"); 
        Console.WriteLine ("3. Quiero retirar dinero de la cuenta"); 
        Console.WriteLine ("Quiero salir del programa"); 
        Console.Write ("Elegir una opcion:"); 
        opcion = int.Parse (Console.ReadLine())
        switch (opcion)
        { 
            case 1: 
            Console.WriteLine("Ingresse la cantidad que quiere depositar");
            double deposito = 
            double.Parse (Console.ReadLine()); 
            saldo + = deposito; 
            Console.WriteLine ("Lo que deposito fue realizado con exito realizado con exito");
            break;
            case 3: 
            Console.Write ("Ingrese la cantidad que quiere retirar: "); 
            double retiro = double.Parse (Console.ReadLine())
            if (retiro <= saldo)
              {
                 saldo -= retiro; 
              Console.WriteLine("Retiro realizado exitosamente");
              } 
              {
                else 
                } 

              Console.WriteLine ("El saldo es insuficiente") ;
                { 
                break; 
                default: 
              
              Console.WriteLine("Opcion invalida, quiero intentarlo de nuevo");
              break; 
              } 
              } while (opcion ! =4); 
             }
         }
                 

