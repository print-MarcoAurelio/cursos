using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");
        double investimento = 1000;

        // Endimento 0,5% (0,005)mês

        // Mês 1
        //investimento = investimento + investimento * 0.005;
        // Mês 2
        //investimento = investimento + investimento * 0.005;
        // Mês 3
        //investimento = investimento + investimento * 0.005;

        Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine($"No mês {mes} você tem {investimento}");
            mes = mes + 1;
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}