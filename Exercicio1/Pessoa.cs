using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Pessoa
    {
        public string Nome { get; protected set; }
        public int Idade { get; protected set; }

        public void ObterDados() 
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a idade da pessoa: ");
            Idade = int.Parse(Console.ReadLine());
        }
    }
}
