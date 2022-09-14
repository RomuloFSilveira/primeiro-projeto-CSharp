using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!\n");

ContaCorrente conta_232425 = new ContaCorrente(43256, "232425");
Cliente Julio = new Cliente();

Julio.Nome = "Julio André Souza";
Julio.Cpf = "451.874.321-54";
Julio.Profissao = "Programador C#";
conta_232425.Conta = "232425";
conta_232425.Titular = Julio;
conta_232425.Nome_Agencia = "Byte Bank";
conta_232425.Numero_agencia = 43256;
conta_232425.Saldo = 125.0;


ContaCorrente conta_223344 = new ContaCorrente(43256, "223344");
Cliente Kelven = new Cliente();

Kelven.Nome = "Kelven Oliveira";
Kelven.Cpf = "584.659.845-12";
Kelven.Profissao = "Entregador de Jornal";
conta_223344.Conta = "223344";
conta_223344.Titular = Kelven;
conta_223344.Nome_Agencia = "Byte Bank";
conta_223344.Numero_agencia = 43256;
conta_223344.Saldo = 1890.50;


ContaCorrente conta_548721 = new ContaCorrente(43256, "548721");
Cliente Alexandre = new Cliente();

Alexandre.Nome = "Alexandre Fernandes Ferraz";
Alexandre.Cpf = "963.521.412-20";
Alexandre.Profissao = "Embaixador da Colombia";
conta_548721.Conta = "548721";
conta_548721.Titular = Alexandre;
conta_548721.Nome_Agencia = "Byte Bank";
conta_548721.Numero_agencia = 43256;
conta_548721.Saldo = 13.50;

//Demonstração do uso dos comandos de Saque, Deposito e Saldo.

conta_548721.Depositar(1000);
conta_223344.Depositar(580.50);


Console.WriteLine("Alexandre depositou uma total de R$1000,00 e agora seu saldo é de: R$" + conta_548721.Saldo);
Console.WriteLine("Kelven depositou uma total de R$580,50 e agora seu saldo é de: R$" + conta_223344.Saldo);

conta_548721.Transferir(550, conta_232425);
conta_548721.Sacar(340.0);

Console.WriteLine("\nAlexandre transferiu R$ 550,80 para Julio e sacou R$340,00. Agora tem um total de: R$" + conta_548721.Saldo + " em sua conta.");
Console.WriteLine("O saldo atual de Julio é de: R$" + conta_232425.Saldo);



Console.WriteLine("\nEstamos no inicio de uma carreira e ainda temos, " + ContaCorrente.TotalDeContasCriadas + " clientes.");


Console.ReadKey();




