// edhfbbefijiebf ewbfv ewfuub eiuufb uebfiew uwebfi
// jbij usdff wei oieww foi djj ewjew sdj fjj sd ej

using System;

class Program
{
    static void Main(string[] args)
    {
        double num1 = 7;
        double num2 = 3;
        double num3 = 5;

        double maior = num1;

        if (num2 > num1)
        {
            maior = num2;
        }
        if (num3 > num1)
        {
            maior = num3;
        }
    
        double menor = num2;

        if(num1 < num2)
        {
            menor = num1;
        }
        if(num3 < num2)
        {
            menor = num3;
        }

        double media = (num1 + num2 + num3) / 3;
        
        Console.WriteLine(maior);
        Console.WriteLine(menor);
        Console.WriteLine(media);
    }

}
