using System;


public interface INotificable
{
   
    void Notificar(string mensaje);
}


public class NotificacionEmail : INotificable
{
 
    private string direccionCorreo;

    
    public NotificacionEmail(string correo)
    {
        direccionCorreo = correo;
    }

    
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando correo a {direccionCorreo}: {mensaje}");
    }
}

public class NotificacionWhatsApp : INotificable
{
    
    private string numeroTelefono;

   
    public NotificacionWhatsApp(string telefono)
    {
        numeroTelefono = telefono;
    }

   
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje por WhatsApp al número {numeroTelefono}: {mensaje}");
    }
}


public class NotificacionSMS : INotificable
{
   
    private string numeroTelefono;

    
    public NotificacionSMS(string telefono)
    {
        numeroTelefono = telefono;
    }

    
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        NotificacionEmail emailNotif = new NotificacionEmail("correo@example.com");
        NotificacionWhatsApp whatsappNotif = new NotificacionWhatsApp("+1234567890");
        NotificacionSMS smsNotif = new NotificacionSMS("123456789");

     
        emailNotif.Notificar("¡Hola desde el correo!");
        whatsappNotif.Notificar("¡Hola desde WhatsApp!");
        smsNotif.Notificar("¡Hola desde un SMS!");
    }
}
