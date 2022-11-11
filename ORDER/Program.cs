using ORDER.entities;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Client data: ");
            System.Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            System.Console.WriteLine("BirthDate: (dd/MM/yyyy)");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            System.Console.WriteLine("Order data:");
            System.Console.WriteLine("Status (PendingPayment, Processing, Shipped, Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            System.Console.WriteLine("How many orders: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Product data: ");

            DateTime moment = DateTime.Now;

            Orders order = new Orders(status, moment, client);

            for(int i = 0; i < n; i++){

                System.Console.WriteLine("Name: ");
                string Pname = Console.ReadLine();
                System.Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(Pname, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.Additem(orderItem);
            }
            System.Console.WriteLine(order);

        }
    }
}