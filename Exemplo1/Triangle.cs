using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Area { get; set; }

        public void ObterLados()
        {
            Console.WriteLine("Digite os valores dos lados do triângulo: ");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
        }
        public double CalculaArea()
        {
            double p = (A + B + C) / 2;
            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return Area;
        }
    }
}
