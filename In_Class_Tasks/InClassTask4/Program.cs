/* Thatcher Wilson
 * Section: 001 (11:30 am)
 * Task4
 */

namespace InClassTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the order total: $");
            double dblTotal = double.Parse(Console.ReadLine());
            Console.WriteLine("Is the customer a member? (Y/N):");
            char chrUserChoice = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items: ");
            int intItemsCount = int.Parse(Console.ReadLine());
            double dblDiscount = 0;

            //if the user if a member and they spent at least 100
            if (chrUserChoice == 'Y' && dblTotal >= 100)
            {
                dblDiscount = 0.15;
            }
            else if (chrUserChoice == 'Y' && dblTotal < 100)
            {
                dblDiscount = 0.10;
            }
            else if (chrUserChoice == 'N' && dblTotal >= 150)
            {
                dblDiscount = 0.05;
            }
            else if (chrUserChoice == 'N' && dblTotal < 150)
            {
                dblDiscount = 0;
            }

            //calculate total after discount
            double dblDiscountAmount = dblDiscount * dblTotal;
            double dblDiscountedTotal = dblTotal - dblDiscountAmount;

            //compute shipping cost
            double dblShipping = 8.99;

            if (dblDiscountedTotal >= 75)
            {
                dblShipping = 0;
            }
            else
            {
                dblShipping = 8.99;
            }
            //final total
            double dblFinalTotal = dblDiscountedTotal + dblShipping;

            //step 4 clean receipt
            Console.WriteLine("=========Receipt==========");
            Console.WriteLine($"Items Purchased:         {intItemsCount}");
            Console.WriteLine($"Original Total:         ${dblTotal:F2}");
            Console.WriteLine($"Discount:               {dblDiscount * 100}%");
            Console.WriteLine($"Discount Amount:        ${dblDiscountAmount:F2}");
            Console.WriteLine($"Total After Discount:   ${dblDiscountedTotal:F2}");

            if (dblShipping == 0)
            {
                Console.WriteLine("Shipping:               FREE");
            }
            else
            {
                Console.WriteLine($"Shipping:               ${dblShipping:F2}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Final Total:            ${dblFinalTotal:F2}");
            Console.WriteLine("===========================");












        }

    }
}


