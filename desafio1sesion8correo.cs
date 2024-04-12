using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string texto = "Este es mi correo electrónico: juan_perez.23@gmail.com. Por favor, envíeme un correo con sus comentarios.";


        string patron = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";

  
        MatchCollection matches = Regex.Matches(texto, patron);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}