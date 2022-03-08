using Exemplo6.Entities;
using System.Globalization;

namespace Exemplo6
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (Y/N): ");
                string option = Console.ReadLine().ToUpper();
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (option == "Y")
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee emp = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(emp);
                }
                else if (option == "N")
                {
                    Employee emp = new Employee(name, hours, valuePerHour);
                    employees.Add(emp);
                }
                else
                {
                    Console.WriteLine("Enter with Y or N.");
                }                
            }           
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}