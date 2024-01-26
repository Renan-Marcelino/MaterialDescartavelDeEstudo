using System;

class Aluno
{
    public string nome;
    public double nota1, nota2;

    public double CalcularMedia()
    {
        return (nota1 + nota2) / 2;
    }

    public string ObterSituacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void ExibirMensagem()
    {
        double obterMedia = CalcularMedia();
        string obterSituacao = ObterSituacao(obterMedia);

        Console.WriteLine($"{nome} está {obterSituacao} com média: {obterMedia}");
    }
}
