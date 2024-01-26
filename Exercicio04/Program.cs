using System;

class Program
{
    static void Main(string[] args)
    {
        Pessoa x = new Pessoa();
        x.peso = 50;
        x.altura = 173;
        double IMC = x.CalcularIMC();
        Console.WriteLine(IMC);
    }


}