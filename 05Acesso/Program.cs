using System;

class Program
{
    static void Main(string[] args)
    {
        Aluno Pessoa = new Aluno();

        Pessoa.nome = "joao";
        Pessoa.nota1 = double.Parse(Console.ReadLine());
        Pessoa.nota2 = double.Parse(Console.ReadLine());

        double media = Pessoa.calcularMedia();

        public string situacao = media >=7 ? "Aprovado" : "Reprovado";

        Console.WriteLine($"ola {Pessoa.nome} sua media foi {media} e você esta {stuacao}");

    }
}