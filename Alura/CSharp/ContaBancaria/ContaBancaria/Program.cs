Conta conta = new Conta();
conta.titular = "Gui Lima";
conta.id = 1;
conta.saldo = 20.00;
conta.senha = 1234;

Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular {conta.titular}");
Console.WriteLine($"Saldo atual: {conta.saldo}");

public void exibirInformacoes()
{
    Console.WriteLine("INFO")
}
