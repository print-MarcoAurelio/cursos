using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 17;
        int quantidadePessoas = 3;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("infelizmente você não pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}