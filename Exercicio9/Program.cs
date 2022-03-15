using Exercicio9.Entities;
using System.Globalization;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();
            
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (I/C)? ");
                string typeOfPayer = Console.ReadLine().ToUpper();
                if (typeOfPayer == "I")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    payers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (typeOfPayer == "C")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Payer payer in payers)
            {
                Console.WriteLine($"{payer.Name}: ${payer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += payer.TaxesPaid();
            }

            Console.WriteLine($"TOTAL TAXES: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}