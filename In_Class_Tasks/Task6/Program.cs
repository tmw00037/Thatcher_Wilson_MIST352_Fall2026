/* Thatcher Wilson
 * Section 001 11:30am
 * 10/20/2026
 * In-Class Task6
 */

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of rows: ");
            int intUserInput = int.Parse(Console.ReadLine());


            if (IsValidRows(intUserInput))
            {
                PrintStars(intUserInput);

                int intTotal = CountStars(intUserInput);
                Console.WriteLine();
                Console.WriteLine($"Total stars: {intTotal}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }


        public static void PrintStars(int intRows)
        {
            int intRow = 1;
            while (intRow <= intRows)
            {
                for (int intIndex = 1; intIndex <= intRow; intIndex++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                intRow++;
            }
        }


        public static int CountStars(int intRows)
        {
            int intTotal = 0;
            for (int intRow = 1; intRow <= intRows; intRow++)
            {
                intTotal += intRow;
            }
            return intTotal;
        }


        public static bool IsValidRows(int intRows)
        {
            if (intRows >= 1 && intRows <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}