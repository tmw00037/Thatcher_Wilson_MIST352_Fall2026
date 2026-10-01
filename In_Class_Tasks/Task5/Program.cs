/* Thatcher Wilson
 * Section 001 11:30am
 * 10/1/2026
 * In-Class Task5
 */


using System.ComponentModel.Design;
using System.Data;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user to enter a number
            Console.WriteLine("Give me a number between 1 and 10");
            int intUserInput = int.Parse(Console.ReadLine());
            //verify number between 1 and 10

            if (intUserInput >= 1 && intUserInput <= 10) 
            {
                //print good input
                Console.WriteLine("Good number");
                int intRow = 1;
                while (intRow <= intUserInput)
                {
                    for (int intIndex = 1; intIndex <= intRow; intIndex++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    intRow++;
                }
            }

            else
            {
                //invalid input
                Console.WriteLine("Invalid number");
            }





        }
    }
}
