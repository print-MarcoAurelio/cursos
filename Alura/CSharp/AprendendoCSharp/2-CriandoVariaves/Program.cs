using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");
        int idade;
        idade = 22;
        Console.WriteLine("Minha Idade é " + idade);
        idade = 22 - 5;
        Console.WriteLine(idade);
        idade = 5 * 2 - 6;
        Console.WriteLine(idade);
        idade = (5 - 2) * 3;
        Console.WriteLine(idade);

        Console.WriteLine("Aperte enter para fechar...");
        Console.ReadLine();
    }
}
