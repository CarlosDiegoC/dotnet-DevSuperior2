using System;
using System.Globalization;
namespace Exemplo2 
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio para o qual deseja calcular o perímetro da circunferência: ");
            double raio = double.Parse(Console.ReadLine());

            Geometria.Circunferencia(raio);
            Console.WriteLine($"A circunferência de raio {raio} tem perímetro: {Geometria.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"A esfera de raio {raio} tem volume: {Geometria.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
        }        
    }
}