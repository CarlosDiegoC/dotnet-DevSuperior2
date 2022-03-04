using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2
{
    class Produto
    {
        /* Ordem sugerida para implementar membros:
         * - Atributos Privados.
         * - Auto Propriedades.
         * - Métodos Construtores
         * - Propriedades Customizadas.
         * - Demais Métodos.
         */
        private string _nome; // Mantive o nome do produto como um atributo privado devido a necessidade de implementar uma lógica ao setar o nome para garantir consistência.
        public double Preco { get; private set; } // Auto propriedade.
        public int Quantidade { get; private set; } // Auto propriedade.

        public Produto(string nome, double preco, int quantidade) // Construtor com os três parâmetros.
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome // Implementação da propriedade customizada do atributo _nome com a garantia de consistência ao modificar o nome do produto. 
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque() // Método para verificar o valor em reais do estoque de determinado produto.
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos() // Método para adicionar produtos ao estoque.
        {
            Console.Write("Digite a quantidade que deseja adicionar: ");
            int quantidadeAdicionada = int.Parse(Console.ReadLine());
            Quantidade += quantidadeAdicionada;
        }

        public void RemoverProdutos() // Método para remover produtos do estoque.
        {
            Console.Write("Digite a quantidade que deseja remover: ");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            Quantidade -= quantidadeRemovida;
        }

        public override string ToString() // Sobrescrita do método ToString para exibir o objeto em um formato visual amigável.
        {
            string retorno = "";
            retorno += "Produto: " + this._nome + Environment.NewLine;
            retorno += "Preço: R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + Environment.NewLine;
            retorno += "Quantidade: " + this.Quantidade + Environment.NewLine;
            retorno += "Valor Total Em Estoque: R$" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            return retorno;
        }
    
    }
}