using Exercicio7.Entities;
using Exercicio7.Entities.Enums;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());            
            
            Client client = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("***************************");
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Order order = new Order(status, client);
            
            Console.Write("How many items to this order? ");
            
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Product product = new Product(productName, productPrice);
                
                Console.Write("Quantity: ");
                int itemQuantity = int.Parse(Console.ReadLine());
                
                OrderItem item = new OrderItem(product, itemQuantity, productPrice);
                order.AddItem(item);

            }
            Console.WriteLine("");
            Console.WriteLine(order);
        }
    }
}