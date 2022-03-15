using Exercicio10.Entites;
using Exercicio10.Services;
using System.Globalization;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Contract number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            Console.Write("Enter number of installments: ");
            int installmentsQuantity = int.Parse(Console.ReadLine());

            InstallmentService installmentService = new InstallmentService(installmentsQuantity, new PaypalService());
            installmentService.ProcessInstallments(contract);
            
            Console.WriteLine("Installments:");
            
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}