using System;

class Pessoa
{
    public double peso;
    public double altura;


    public double CalcularIMC()
    {
       double imc = peso / (altura * altura);
       return imc;
    }

}