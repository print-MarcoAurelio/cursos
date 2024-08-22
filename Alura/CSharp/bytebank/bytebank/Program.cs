using bytebank;

ContaCorrente contaDoMarco = new ContaCorrente();
contaDoMarco.titular = "Marco Aurélio";
contaDoMarco.numero_agencia = 15;
contaDoMarco.conta = "1010-X";
contaDoMarco.saldo = 100;

Console.WriteLine($"Saldo da conta do Marco = {contaDoMarco.saldo}");

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine($"Saldo da conta da Maria = {contaDaMaria.saldo}");

contaDaMaria.Transferir(50, contaDaMaria);
System.Console.WriteLine($"Saldo do André = {contaDoMarco.saldo}");
System.Console.WriteLine($"Conta da Maria = {contaDaMaria.saldo}");

ContaCorrente contaDoPedro = new ContaCorrente();
System.Console.WriteLine(contaDoPedro.titular);
System.Console.WriteLine(contaDoPedro.saldo);
System.Console.WriteLine(contaDoPedro.numero_agencia);
System.Console.WriteLine(contaDoPedro.conta);

/*
contaDoMarco.Depositar(100);

Console.WriteLine($"Saldo da conta do Marco = {contaDoMarco.saldo}");

if (contaDoMarco.Sacar(300) == true){
    System.Console.WriteLine($"Saldo da conta do Marco pós-saque = {contaDoMarco.saldo}");
}else{
    System.Console.WriteLine("Valor indisponivel");
}
*/
