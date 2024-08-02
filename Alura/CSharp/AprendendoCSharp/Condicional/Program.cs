using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 17;
        int quantidadePessoas = 3;

        if (idade >= 18)
        {
            Console.WriteLine("Você tem mais que 18 anos");
        }
        else
        {
            if(quantidadePessoas > 2)
            {
                Console.WriteLine("voce nao tem 18, mas pode entrar, pois está acompanhado");
            }
            Console.WriteLine("infelizmente você não pode entrar");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
