using System;
using System.Globalization;

class Twitter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o texto a ser convertido: ");
        string texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string textoConvertido = textInfo.ToTitleCase(texto);
            Console.WriteLine(textoConvertido);
        }
        else
        {
            Console.WriteLine("Texto vazio. Nada a converter.");
        }
    }
}
