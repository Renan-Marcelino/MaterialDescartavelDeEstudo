// Criar uma função que receba tres numeros
// informar o maior o menor e a media

using System;

class Program
{
    static void Main(string[] args)
    {
        double numero1 = 5;
        double numero2 = 8;
        double numero3 = 1;


        double maior = numero1;
        if(numero2 > numero1)
        {
        maior = numero2;
        }
        if(numero3 > numero1)
        {
        maior = numero3;
        }

        if (numero1 > numero2 && numero2 > numero3)
        {
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
        }
        else if (numero2 > numero1 && numero1 > numero3)
        {
            Console.WriteLine(numero2);
            Console.WriteLine(numero1);
            Console.WriteLine(numero3);
        }
        else if (numero3 > numero2 && numero2 > numero1)
        {
            Console.WriteLine(numero3);
            Console.WriteLine(numero2);
            Console.WriteLine(numero1);
        }
        else if (numero1 > numero2 && numero3 > numero2)
        {
            Console.WriteLine(numero1);
            Console.WriteLine(numero3);
            Console.WriteLine(numero2);
        }
        else if (numero2 > numero1 && numero3 > numero1)
        {
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero1);
        }
        else
        {
            Console.WriteLine(numero3);
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
        }

            Console.WriteLine(maior);
       
    }
}
