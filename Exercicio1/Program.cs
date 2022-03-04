using System;

namespace Exercicio1 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Pessoa pessoa1 = new Pessoa();
            Console.WriteLine("Obtendo os dados da primeira pessoa...");
            pessoa1.ObterDados();

            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("Obtendo os dados da segunda pessoa...");
            pessoa2.ObterDados();

            if (pessoa1.Idade > pessoa2.Idade) 
            {
                Console.WriteLine($"{pessoa1.Nome} é a pessoa mais velha.");
            }
            
            else if (pessoa1.Idade == pessoa2.Idade)
            {
                Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} tem a mesma idade.");
            }
            
            else 
            {
                Console.WriteLine($"{pessoa2.Nome} é a pessoa mais velha.");
            }
        }
    }
}