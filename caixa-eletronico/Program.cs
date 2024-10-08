// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        double saldo = 0;
        double limiteSaque;
        double limiteTransacaoDiaria = 10000;
        double valorTransacaoDiaria = 0;
        string usuarioNome = "Usuário";
        string usuarioTipoConta;
        string senhaCorreta = "123456"; // senha fixa para simular autenticação
        int tentativasSenha = 3;

        // Autenticação de senha
        while (tentativasSenha > 0)
        {
            Console.Write("Digite sua senha (6 dígitos): ");
            string senhaDigitada = Console.ReadLine();

            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("Autenticação realizada com sucesso!\n");
                break;
            }
            else
            {
                tentativasSenha--;
                Console.WriteLine($"Senha incorreta! Você tem {tentativasSenha} tentativa(s) restante(s).");

                if (tentativasSenha == 0)
                {
                    Console.WriteLine("Você atingiu o limite de tentativas. Saindo do sistema.");
                    return;
                }
            }
        }

        // Escolha do tipo de conta
        Console.WriteLine("Escolha o tipo de conta:");
        Console.WriteLine("1. Corrente");
        Console.WriteLine("2. Poupança");
        Console.Write("Digite o número da opção: ");
        string tipoContaOpcao = Console.ReadLine();

        switch (tipoContaOpcao)
        {
            case "1":
                usuarioTipoConta = "Corrente";
                limiteSaque = 500;
                break;
            case "2":
                usuarioTipoConta = "Poupança";
                limiteSaque = 1000;
                break;
            default:
                Console.WriteLine("Opção inválida! Considerando conta Corrente.");
                usuarioTipoConta = "Corrente";
                limiteSaque = 500;
                break;
        }

        while (true)
        {
            Console.WriteLine($"\n=== Caixa Eletrônico - Conta {usuarioTipoConta} ===");
            Console.WriteLine("1. Depósito");
            Console.WriteLine("2. Saque");
            Console.WriteLine("3. Extrato");
            Console.WriteLine("4. Transferência");
            Console.WriteLine("5. Aplicação Financeira");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o valor do depósito: ");
                    double valorDeposito = Convert.ToDouble(Console.ReadLine());
                    saldo += valorDeposito;
                    valorTransacaoDiaria += valorDeposito;
                    Console.WriteLine($"Depósito de R${valorDeposito} realizado com sucesso!");
                    break;

                case "2":
                    Console.Write("Digite o valor do saque: ");
                    double valorSaque = Convert.ToDouble(Console.ReadLine());

                    if (valorSaque > saldo)
                    {
                        Console.WriteLine("Saldo insuficiente!");
                    }
                    else if (valorSaque > limiteSaque)
                    {
                        Console.WriteLine($"Valor do saque excede o limite de R${limiteSaque}!");
                    }
                    else if (valorTransacaoDiaria + valorSaque > limiteTransacaoDiaria)
                    {
                        Console.WriteLine($"Você excedeu o limite diário de transações de R${limiteTransacaoDiaria}!");
                    }
                    else
                    {
                        saldo -= valorSaque;
                        valorTransacaoDiaria += valorSaque;
                        Console.WriteLine($"Saque de R${valorSaque} realizado com sucesso!");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Saldo atual: R${saldo}");
                    break;

                case "4":
                    Console.Write("Digite o valor da transferência: ");
                    double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                    double taxaTransferencia = valorTransferencia * 0.05 / 100;

                    if (valorTransferencia + taxaTransferencia > saldo)
                    {
                        Console.WriteLine("Saldo insuficiente para transferência!");
                    }
                    else if (valorTransacaoDiaria + valorTransferencia > limiteTransacaoDiaria)
                    {
                        Console.WriteLine($"Você excedeu o limite diário de transações de R${limiteTransacaoDiaria}!");
                    }
                    else
                    {
                        saldo -= (valorTransferencia + taxaTransferencia);
                        valorTransacaoDiaria += valorTransferencia;
                        Console.WriteLine($"Transferência de R${valorTransferencia} realizada com sucesso! Taxa aplicada: R${taxaTransferencia}");
                    }
                    break;

                case "5":
                    Console.WriteLine("=== Aplicação Financeira ===");
                    Console.WriteLine("1. Poupança (rend. 0.5% ao mês)");
                    Console.WriteLine("2. CDB (rend. 1% ao mês)");
                    Console.Write("Escolha o tipo de aplicação: ");
                    string tipoAplicacao = Console.ReadLine();

                    Console.Write("Digite o valor da aplicação: ");
                    double valorAplicacao = Convert.ToDouble(Console.ReadLine());

                    if (valorAplicacao > saldo)
                    {
                        Console.WriteLine("Saldo insuficiente para aplicar!");
                    }
                    else
                    {
                        saldo -= valorAplicacao;
                        if (tipoAplicacao == "1")
                        {
                            Console.WriteLine($"Você aplicou R${valorAplicacao} na Poupança. Rendimento de 0.5% ao mês.");
                        }
                        else if (tipoAplicacao == "2")
                        {
                            Console.WriteLine($"Você aplicou R${valorAplicacao} no CDB. Rendimento de 1% ao mês.");
                        }
                        else
                        {
                            Console.WriteLine("Opção de aplicação inválida.");
                        }
                    }
                    break;

                case "6":
                    Console.WriteLine("Saindo do sistema. Até logo!");
                    return;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}

