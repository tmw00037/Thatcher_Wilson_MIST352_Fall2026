namespace Task2B
/*
First Name: Thatcher
Last Name: Wilson
Section: 002 (11:30 AM)
Task: Task2B
Date: 09/01/2026
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
PSEUDOCODE

START

DISPLAY "Event Profit Estimator"

SET processing fee rate to 0.03

DISPLAY "Enter the event name:"
READ event name

DISPLAY "Enter the number of tickets sold:"
READ tickets sold
CONVERT tickets sold to an integer

DISPLAY "Enter the price of one ticket:"
READ ticket price
CONVERT ticket price to a number

DISPLAY "Enter the fixed venue cost:"
READ venue cost
CONVERT venue cost to a number

CALCULATE gross revenue as tickets sold multiplied by ticket price

CALCULATE processing fee as gross revenue multiplied by processing fee rate

CALCULATE total expenses as venue cost plus processing fee

CALCULATE net revenue as gross revenue minus total expenses

DISPLAY a blank line
DISPLAY "EVENT SUMMARY"
DISPLAY event name
DISPLAY tickets sold
DISPLAY gross revenue as currency
DISPLAY processing fee as currency
DISPLAY total expenses as currency
DISPLAY net revenue as currency

END
*/
            //creating prompts
            Console.WriteLine("Event Profit Estimator");
            double processingFeeRate = 0.03;
            Console.WriteLine("Enter the event name:");
            string eventName = Console.ReadLine();
            Console.WriteLine("Enter the number of tickets sold:");
            int ticketsSold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pricce of one ticket:");
            double ticketPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fixed venue cost:");
            double venueCost = Convert.ToDouble(Console.ReadLine());
            //calculations
            double grossRevenue = ticketsSold * ticketPrice;
            double processingFee = grossRevenue * processingFeeRate;
            double totalExpenses = venueCost + processingFee;
            double netRevenue = grossRevenue - totalExpenses;
            //final display
            Console.WriteLine();
            Console.WriteLine("EVENT SUMMARY");
            Console.WriteLine($"Event: {eventName}");
            Console.WriteLine($"Tickets Sold: {ticketsSold}");
            Console.WriteLine($"Gross Revenue: {grossRevenue:C2}");
            Console.WriteLine($"Processing Fee: {processingFee:C2}");
            Console.WriteLine($"Total Expenses: {totalExpenses:C2}");
            Console.WriteLine($"Net Revenue: {netRevenue:C2}");




        }
    }
}
