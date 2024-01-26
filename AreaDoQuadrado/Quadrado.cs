using System;

class Quadrado
{
    public double Base {get; set;}
    public double Altura {get; set;}

    public double Area {get; set;}
    
    public double CalcularArea()
    {
        return Area = Base * Altura;
    }

    public void ExibirArea()
    {
        Console.WriteLine(Area);
    }    
}