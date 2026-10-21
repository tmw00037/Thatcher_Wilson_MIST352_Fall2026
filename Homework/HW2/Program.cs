/* Thatcher Wilson
 * Section 001 11:30am
 * 10/21/2026
 * HW2 #1
*/
namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = File.ReadAllLines("data.txt");
            if (File.Exists("data.txt"))
                Console.WriteLine("Data read successfully.");
            Console.WriteLine("Menue\n A) Print\n B) Count\n C) Avg\n D) Highest GPA\n X) Exit.");

            char chrChoice = Console.ReadLine()[0];

            while (!chrChoice.Equals('X'))
            {
                switch (chrChoice)
                {
                    case 'A':
                        Console.WriteLine("ID        Name                GPA");
                        for (int i = 0; i < students.Length; i++)
                        {
                            string[] data = students[i].Split(',');
                            Console.WriteLine($"{data[0]}   {data[1]}   {data[2]}");
                        }
                        break;
                    case 'B':
                        int intA = 0;
                        int intB = 0;
                        int intC = 0;
                        int intD = 0;

                        for (int i = 0; i < students.Length; i++)
                        {
                            string[] data = students[i].Split(',');
                            double dblGpa = double.Parse(data[2]);

                            if (dblGpa >= 3.7)
                            {
                                intA++;
                            }
                            else if (dblGpa >= 3.0)
                            {
                                intB++;
                            }
                            else if (dblGpa >= 2.0)
                            {
                                intC++;
                            }
                            else
                            {
                                intD++;
                            }
                        }

                        Console.WriteLine($"A: {intA}");
                        Console.WriteLine($"B: {intB}");
                        Console.WriteLine($"C: {intC}");
                        Console.WriteLine($"D: {intD}");
                        break;
                    case 'C':
                        double dblSum = 0;

                        for (int i = 0; i < students.Length; i++)
                        {
                            string[] data = students[i].Split(',');
                            dblSum += double.Parse(data[2]);
                        }

                        double dblAverage = dblSum / students.Length;
                        Console.WriteLine($"Average GPA: {dblAverage:F2}");
                        break;
                    case 'D':
                        double dblHighest = 0;
                        string strHighestId = "";
                        string strHighestName = "";

                        for (int i = 0; i < students.Length; i++)
                        {
                            string[] data = students[i].Split(',');
                            double dblGpa = double.Parse(data[2]);

                            if (dblGpa > dblHighest)
                            {
                                dblHighest = dblGpa;
                                strHighestId = data[0];
                                strHighestName = data[1];
                            }
                        }

                        Console.WriteLine($"Highest GPA: {strHighestId} {strHighestName} ({dblHighest:F2})");
                        break;
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("Invalid option");

                        break;
                }
                Console.WriteLine("Menue\n A) Print\n B) Count\n C) Avg\n D) Highest GPA\n X) Exit.");

                chrChoice = Console.ReadLine()[0];

            }



        }
    }
}
