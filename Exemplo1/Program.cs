using System;
using System.Collections.Generic;
using System.Globalization;
namespace Section4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Definindo o primeiro triângulo...");
            Triangle triangle1 = new Triangle();
            triangle1.ObterLados();

            Console.WriteLine("Definindo o segundo triângulo...");
            Triangle triangle2 = new Triangle();
            triangle2.ObterLados();

            triangle1.CalculaArea();
            triangle2.CalculaArea();

            Console.WriteLine($"A área do primeiro triângulo é: {triangle1.Area:N4} metros quadrados");
            Console.WriteLine($"A área do segundo triângulo é: {triangle2.Area:N4} metros quadrados");

            if (triangle1.Area > triangle2.Area)
            {
                Console.WriteLine("A área do primeiro triângulo é maior.");
            }
            else if (triangle1.Area == triangle2.Area)
            {
                Console.WriteLine("A área dos dois triângulos é igual");
            }
            else
            {
                Console.WriteLine("A área do segundo triângulo é maior.");
            }
        }
    }
}