using System;
namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta a ser criada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta a ser criada: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (S/N): ");
            string depositoInicial = Console.ReadLine().ToUpper();

            if (depositoInicial == "S")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(titular, numero, saldo);               
            }
            else
            {
                conta = new ContaBancaria(titular, numero);
            }

            Console.WriteLine("\nDados da Conta:");
            Console.WriteLine(conta);

            Console.Write("Digite o valor que deseja depositar na conta: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            
            conta.Deposito(valorDeposito);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("Digite o valor que deseja sacar da conta: ");
            double valorSaque = double.Parse(Console.ReadLine());

            conta.Saque(valorSaque);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(conta);

            conta.ConsultarSaldo();
        }
    }
}