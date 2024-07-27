using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 300.15;
        Console.WriteLine(salario);

        //O int é um tipo de variável de 64 bits
        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //O long é um tipo de variável de 64 bits
        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Aperta enter para fechar...");
        Console.ReadLine();
    }
}
