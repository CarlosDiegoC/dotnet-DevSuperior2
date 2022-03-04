using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Console.Write("Enter the number of employees that will be registred: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"#Employee {i}:");
                
                Console.Write("Enter the employee ID: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Enter the employee name: ");
                string name = Console.ReadLine();

                Console.Write("Enter the emplyee salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                employeeList.Add(new Employee(id, name, salary));                
            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int idToIncrease = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the percent value to increase the salary: ");
            double percentIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee employeeThatWillReceiveAIncrease = employeeList.Find( employee => employee.Id == idToIncrease);

            employeeThatWillReceiveAIncrease.IncreaseSalary(percentIncrease);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($" |ID: {employee.Id} |NAME: {employee.Name} |SALARY: {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }


        }
                
    }
}