using System;

class Program
{
    static void Main(string[] args)
    {
        Animais a1 = new Animais();
        a1.Nome = Console.ReadLine();
        a1.Tipo = Console.ReadLine()?.ToUpper();

        a1.TestarTipo();

        Animais a2 = new Animais();
        a2.Nome = Console.ReadLine();
        a2.Tipo = Console.ReadLine()?.ToUpper();

        a2.TestarTipo();

        Animais a3 = new Animais();
        a3.Nome = Console.ReadLine();
        a3.Tipo = Console.ReadLine()?.ToUpper();

        a3.TestarTipo();

        Animais a4 = new Animais();
        a4.Nome = Console.ReadLine();
        a4.Tipo = Console.ReadLine()?.ToUpper();

        a4.TestarTipo();

        Animais a5 = new Animais();
        a5.Nome = Console.ReadLine();
        a5.Tipo = Console.ReadLine()?.ToUpper();

        a5.TestarTipo();
        
        
        Animais.ApresentarAnimais();
    }
}
