namespace Task2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USB Drive Order Estimator");

            double taxRate = 0.06;
            double shippingCostPerBox = 4.50;

            Console.WriteLine("Enter the customer or company name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter the number of USB drives ordered:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of one USB drive:");
            double unitPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of USB drives that fit in one box:");
            int unitsPerBox = Convert.ToInt32(Console.ReadLine());
            
            double merchandiseSubtotal = quantity * unitPrice;

            double numberOfBoxes = Math.Ceiling((double)quantity / unitsPerBox);

            double shippingCost = numberOfBoxes * shippingCostPerBox;

            double salesTax = merchandiseSubtotal * taxRate;

            double finalTotal = merchandiseSubtotal + shippingCost + salesTax;

            // final formatting
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine($"Customer: {customerName}");
            Console.WriteLine($"Quantity Ordered: {quantity}");
            Console.WriteLine($"Number of Boxes: {numberOfBoxes}");
            Console.WriteLine($"Merchandise Subtotal: {merchandiseSubtotal:C2}");
            Console.WriteLine($"Shipping Cost: {shippingCost:C2}");
            Console.WriteLine($"Sales Tax: {salesTax:C2}");
            Console.WriteLine($"Final Total: {finalTotal:C2}");






        }
    }
}
