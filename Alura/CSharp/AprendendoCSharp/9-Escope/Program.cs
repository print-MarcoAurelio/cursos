using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 17;
        int quantidadePessoas = 3;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if(acompanhado == true)
        {
             textoAdicional = "João está acompanhado";
        }
        else
        {
             textoAdicional = "João não esta acompanhado";
        }

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
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