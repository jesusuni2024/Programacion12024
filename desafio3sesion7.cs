using System;
using System.Collections.Generic;
using System.IO;

public class Auto
{
    
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public List<string> HistoriaReparaciones { get; private set; }

   
    public Auto(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        HistoriaReparaciones = new List<string>();
    }

   
    public void AgregarReparacion(string reparacion)
    {
        HistoriaReparaciones.Add(reparacion);
    }

    
    public void HistoriaDeReparaciones()
    {
        foreach (string reparacion in HistoriaReparaciones)
        {
            Console.WriteLine(reparacion);
        }
    }
}

public class BMW : Auto
{
    
    public BMW(string marca, string modelo) : base(marca, modelo)
    {
    }
    
    public void Reparar(string reparacion)
    {
        AgregarReparacion(reparacion);
        GuardarReparacionEnArchivo(reparacion);
    }

  
    private void GuardarReparacionEnArchivo(string reparacion)
    {
        string path = "reparaciones.txt";
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine(reparacion);
        }
    }

   
    public new void HistoriaDeReparaciones()
    {
        string path = "reparaciones.txt";
        if (File.Exists(path))
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string reparacion;
                while ((reparacion = sr.ReadLine()) != null)
                {
                    Console.WriteLine(reparacion);
                }
            }
        }
        else
        {
            Console.WriteLine("No hay reparaciones registradas.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        BMW miBMW = new BMW("BMW", "Serie 3");

        
        miBMW.Reparar("Cambio de aceite");
        miBMW.Reparar("Cambio de frenos");
        miBMW.Reparar("Reparación de motor");

     
        Console.WriteLine("Historia de reparaciones:");
        miBMW.HistoriaDeReparaciones();
    }
}
