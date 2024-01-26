using System;

class Aluno
{
    public string nome {get;set;}
    public double nota1 {get;set;}
    public double nota2 {get;set;}

    public double calcularMedia()
    {
        return (nota1 + nota2) / 2;

    }
}