using System;
using System.Globalization;
namespace Exercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = ObterOpcaoUsuario();            
            while (opcao != 2)
            {
                Console.WriteLine("Digite a cotação atual do dolar: ");
                double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o valor em dolares que você deseja comprar: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"O valor em reais necessário será de: R${ConversorDeMoeda.DolarParaReais(cotacao, valor).ToString("F2", CultureInfo.InvariantCulture)}");
                opcao = ObterOpcaoUsuario();
            }
        }        
        
        public static int ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Digite 1 para converter um valor de dolares para reais.");
            Console.WriteLine("Digite 2 para sair.");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return opcao;
        }
    }
}