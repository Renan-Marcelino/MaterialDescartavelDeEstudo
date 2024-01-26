using System;

class Animais
{
    public string Nome {get; set;}
    public string Tipo {get; set;}

    public static double Gato {get; private set;}
    public static double Cachorro {get; private set;}
    public static double Peixe {get; private set;}

    public static void ApresentarAnimais()
    {
        Console.WriteLine($"Foram apresentados {Cachorro} cachorro(s), {Gato} Gato(s) e {Peixe} Peixe(s).");
    }

    public void TestarTipo()
    {
        if(Tipo == "GATO")
        {
            Gato++;
        }else if(Tipo == "CACHORRO")
        {
            Cachorro++;
        }else
        {
            Peixe++;
        }

    }
}