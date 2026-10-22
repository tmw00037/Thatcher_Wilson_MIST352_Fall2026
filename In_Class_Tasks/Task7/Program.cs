/* Thatcher Wilson
 * Section 001 11:30am
 * 10/22/2026
 * Task7
 */

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter today's temperature: ");
            int temperature = int.Parse(Console.ReadLine());

            Console.Write("Enter how many cups were sold: ");
            int cups = int.Parse(Console.ReadLine());

            
            DisplayReport(temperature, cups);
        }

        
        public static double GetPrice(int temperature)
        {
            if (temperature >= 80)
            {
                return 4.00;
            }
            else
            {
                return 3.00;
            }
        }


        public static void DisplayReport(int temperature, int cups)
        {
            double price = GetPrice(temperature);
            double sales = price * cups;
            double cost = 1.50 * cups;
            double profit = sales - cost;

            Console.WriteLine($"Sales: ${sales:F2}");
            Console.WriteLine($"Cost: ${cost:F2}");
            Console.WriteLine($"Profit: ${profit:F2}");
        }
    }
}