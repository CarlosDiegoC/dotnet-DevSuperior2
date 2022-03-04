using System.Globalization;
namespace Exercicio2
{
    public class Program 
    { 
        static void Main(string[] args) 
        {            
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Digite a quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            produto.ValorTotalEmEstoque();
            Console.WriteLine(produto);

            produto.AdicionarProdutos();
            Console.WriteLine(produto);

            produto.RemoverProdutos();
            Console.WriteLine(produto);

            Console.WriteLine("Pressione Enter Para Finalizar Aplicação.");
            Console.ReadLine();

        }
    }
}