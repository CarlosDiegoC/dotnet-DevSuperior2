namespace Exemplo3
{ 
    class Program 
    {
        static void Main(string[] args)
        {            
            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                
                Console.Write("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                vetor [i] = new Produto(nome, preco);
            }

            double soma = 0;
            foreach (Produto produto in vetor)
            {
                soma += produto.Preco;
            }

            double media = soma / n;
            Console.WriteLine("A média de preços dos produtos é: R$" + media);
        }
    }
}