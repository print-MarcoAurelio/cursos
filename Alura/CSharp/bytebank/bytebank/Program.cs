using bytebank;

ContaCorrente contaDoMarco = new ContaCorrente();
contaDoMarco.titular = "Marco Aurélio";
contaDoMarco.numero_agencia = 15;
contaDoMarco.conta = "1010-X";
contaDoMarco.saldo = 300;

Console.WriteLine($"Saldo da conta do Marco = {contaDoMarco.saldo}");