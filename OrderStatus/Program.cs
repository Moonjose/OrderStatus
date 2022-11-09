using OrderStatus.Entities;
using OrderStatus.Entities.Enums;
using System.Diagnostics;
using System.Globalization;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
Order_Status status = Enum.Parse<Order_Status>(Console.ReadLine());

Client client = new Client(clientName, email, birthDate);
Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items tho this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) {
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Product product = new Product(productName, productPrice);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    OrderItem orderItem = new OrderItem(quantity, productPrice, product);
    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);