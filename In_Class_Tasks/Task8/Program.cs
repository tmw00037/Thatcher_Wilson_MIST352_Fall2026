/*
 * Thatcher Wilson
 * Section 001 11:30am
 * Task8
 * 11/10/2026
*/
namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("CPU", 499);
            Product p2 = new Product("Keyboard", -25);   
            Product p3 = new Product("Monitor", 189.99);

            Order o1 = new Order(101, "Thatcher", p1);
            Order o2 = new Order(0, "Alex", p2);
            Order o3 = new Order(103, "Jordan", p3);

            Console.WriteLine("=== Before corrections ===");
            Console.WriteLine($"{p1.GetName()}  ${p1.GetUnitPrice():F2}");
            Console.WriteLine($"{p2.GetName()}  ${p2.GetUnitPrice():F2}");
            Console.WriteLine($"{p3.GetName()}  ${p3.GetUnitPrice():F2}");
            Console.WriteLine($"Order #{o1.GetOrderNumber()}  {o1.GetCustomerName()}  {o1.GetProduct().GetName()}  ${o1.GetProduct().GetUnitPrice():F2}");
            Console.WriteLine($"Order #{o2.GetOrderNumber()}  {o2.GetCustomerName()}  {o2.GetProduct().GetName()}  ${o2.GetProduct().GetUnitPrice():F2}");
            Console.WriteLine($"Order #{o3.GetOrderNumber()}  {o3.GetCustomerName()}  {o3.GetProduct().GetName()}  ${o3.GetProduct().GetUnitPrice():F2}");


            p2.SetUnitPrice(25);
            o2.SetOrderNumber(102);

            Console.WriteLine();
            Console.WriteLine("=== After corrections ===");
            Console.WriteLine($"{p2.GetName()}  ${p2.GetUnitPrice():F2}");
            Console.WriteLine($"Order #{o2.GetOrderNumber()}  {o2.GetCustomerName()}  {o2.GetProduct().GetName()}  ${o2.GetProduct().GetUnitPrice():F2}");
        }
    }
}
