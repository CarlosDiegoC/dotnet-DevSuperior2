using System;
namespace Exercicio3
{
    static class ConversorDeMoeda
    {
        static double Cotacao;

        static double ValorEmDolares;
        public static double DolarParaReais(double Cotacao, double ValorEmDolares)
        { 
            return (ValorEmDolares * Cotacao)*1.06;
        }
    }
}
