using bytebank;

ContaCorrente contaDoMarco = new ContaCorrente();
contaDoMarco.titular = "Marco Aurélio";
contaDoMarco.numero_agencia = 15;
contaDoMarco.conta = "1010-X";
contaDoMarco.saldo = 100;

Console.WriteLine($"Saldo da conta do Marco = {contaDoMarco.saldo}");

contaDoMarco.Depositar(100)
Console.WriteLine($"Saldo da conta do Marco = {contaDoMarco.saldo}");
