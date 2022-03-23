using System.Collections.Generic;
namespace TrabalhandoComListas
{
    public class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIANDO A LISTA DE PESSOAS E ADICIONANDO OBJETOS PESSOA A ELA.
            List<Pessoa> listaDePessoas = new List<Pessoa>()
            {
                new Pessoa("João", 15),
                new Pessoa("Leandro", 21),
                new Pessoa("Paulo", 17),
                new Pessoa("Jessica", 18)
            };


            // ORDENANDO A LISTA DE PESSOAS POR ORDEM DECRESCENTE DE IDADE E SELECIONANDO A PESSOA MAIS VELHA (POSIÇÃO 0).
            Pessoa pessoaMaisVelha = listaDePessoas.OrderByDescending(pessoa => pessoa.Idade).ToList()[0];
            Console.WriteLine("\nA PESSOA MAIS VELHA É: " + pessoaMaisVelha);


            // EXIBINDO CADA PESSOA DA LISTA DE PESSOAS.
            Console.WriteLine("\nPESSOAS NA LISTA:");
            listaDePessoas.ForEach(pessoa => Console.WriteLine(pessoa));
                        
            
            // NÚMERO DE PESSOAS NA LISTA ANTES DAS EXCLUSÕES.
            Console.WriteLine($"\nA QUANTIDADE DE PESSOAS NA LISTA É: {listaDePessoas.Count}");

            
            // REMOVENDO PESSOAS COM IDADE INFERIOR A 18 ANOS.
            listaDePessoas.RemoveAll(pessoa => pessoa.Idade < 18);

            
            // NÚMERO DE PESSOAS NA LISTA APÓS AS EXCLUSÕES DAS PESSOAS COM IDADE INFERIOR A 18.
            Console.WriteLine($"\nAPÓS AS EXCLUSÕES, A QUANTIDADE DE PESSOAS NA LISTA É: {listaDePessoas.Count}");


            // VERIFICAR E RETORNAR TODAS AS PESSOAS NA LISTA QUE TENHAM O NOME JESSICA.
            var pessoaProcurada = listaDePessoas.Where(pessoa => pessoa.Nome == "Jessica").ToList();
            pessoaProcurada.ForEach(pessoa => Console.WriteLine($"\nPessoa encontrada: {pessoa}"));


            // ALTERNATIVA PARA APENAS VERIFICAR SE EXISTE ALGUMA PESSOA COM NOME JESSICA NA LISTA.
            if (listaDePessoas.Exists(pessoa => pessoa.Nome == "Jessica")) Console.WriteLine("\nJessica está na lista.");
            else Console.WriteLine("Jessica não está na lista.");
        }
    }
}