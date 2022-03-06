using System.Globalization;
using Exemplo5.Entities;
using Exemplo5.Entities.Enums;

namespace Exemplo5 
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(departmentName);
            
            Worker worker = new Worker(workerName, workerLevel, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker?: ");
            
            int numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine($"Enter with #{i} contract data: ");
                Console.Write("Enter with contract date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(contractDate, valuePerHour, hours);
                
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear} = {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}