using System;

class Program
{
    static void Main(string[] args)
    {
        Quadrado q1 = new Quadrado();
        q1.Base = double.Parse(Console.ReadLine());
        q1.Altura = double.Parse(Console.ReadLine());

        q1.CalcularArea();
        q1.ExibirArea();
    }
}
