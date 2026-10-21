/*
 * Student Name: Thatcher Wilson
 * Course: MIST352
 * Assignment: HW2_LLM
 *
 * LLM Used: ChatGPT (GPT-6)
 *
 * Prompt:
 * "Write a C# Student Records Program for MIST352 Homework #2.
 * Read student records from data.txt into a string array.
 * Display a repeating menu with options A, B, C, D, and X.
 * Option A displays student ID, name, and GPA in a table.
 * Option B counts students in A, B, C, and D GPA categories.
 * Option C calculates the average GPA.
 * Option D displays the ID and name of the student with
 * the highest GPA. Option X exits. Invalid choices should
 * display Invalid option and return to the menu."
 */

using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string filePath = Path.Combine(
    AppDomain.CurrentDomain.BaseDirectory,
    "TextFile2.txt"
);

        string[] students;

        try
        {
            students = File.ReadAllLines(filePath);
        }
        catch (IOException)
        {
            Console.WriteLine("Error: Could not read file.");
            return;
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: Could not read file.");
            return;
        }

        string choice = "";

        while (choice != "X")
        {
            Console.WriteLine();
            Console.WriteLine("STUDENT RECORDS MENU");
            Console.WriteLine("A. Display Student Table");
            Console.WriteLine("B. Count Students by Letter Grade");
            Console.WriteLine("C. Show Average GPA");
            Console.WriteLine("D. Show Highest GPA Student");
            Console.WriteLine("X. Exit");
            Console.Write("Enter your choice: ");

            choice = Console.ReadLine()?.Trim().ToUpperInvariant() ?? "";

            switch (choice)
            {
                case "A":
                    DisplayStudentTable(students);
                    break;

                case "B":
                    CountStudentsByGrade(students);
                    break;

                case "C":
                    ShowAverageGPA(students);
                    break;

                case "D":
                    ShowHighestGPAStudent(students);
                    break;

                case "X":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    static bool TryParseStudent(
        string line,
        out string studentID,
        out string name,
        out double gpa)
    {
        studentID = "";
        name = "";
        gpa = 0.0;

        line = line.Trim();

        if (line == "")
        {
            return false;
        }

        string[] fields;

        if (line.Contains(","))
        {
            fields = line.Split(',');
        }
        else if (line.Contains("\t"))
        {
            fields = line.Split('\t');
        }
        else if (line.Contains("|"))
        {
            fields = line.Split('|');
        }
        else if (line.Contains(";"))
        {
            fields = line.Split(';');
        }
        else
        {
            fields = line.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            if (fields.Length < 3)
            {
                return false;
            }

            studentID = fields[0];
            name = string.Join(
                " ",
                fields,
                1,
                fields.Length - 2
            );

            return double.TryParse(
                fields[fields.Length - 1],
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out gpa
            );
        }

        if (fields.Length < 3)
        {
            return false;
        }

        studentID = fields[0].Trim().Trim('"');

        name = string.Join(
            " ",
            fields,
            1,
            fields.Length - 2
        ).Trim().Trim('"');

        string gpaText = fields[fields.Length - 1]
            .Trim()
            .Trim('"');

        return double.TryParse(
            gpaText,
            NumberStyles.Float,
            CultureInfo.InvariantCulture,
            out gpa
        );
    }

    static void DisplayStudentTable(string[] students)
    {
        Console.WriteLine();
        Console.WriteLine(
            "{0,-15} {1,-30} {2,8}",
            "Student ID", "Name", "GPA"
        );

        Console.WriteLine(
            new string('-', 57)
        );

        int count = 0;

        foreach (string line in students)
        {
            string id;
            string name;
            double gpa;

            if (TryParseStudent(line, out id, out name, out gpa))
            {
                Console.WriteLine(
                    "{0,-15} {1,-30} {2,8:F2}",
                    id, name, gpa
                );

                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No student records found.");
        }
    }

    static void CountStudentsByGrade(string[] students)
    {
        int aCount = 0;
        int bCount = 0;
        int cCount = 0;
        int dCount = 0;

        foreach (string line in students)
        {
            string id;
            string name;
            double gpa;

            if (TryParseStudent(line, out id, out name, out gpa))
            {
                if (gpa >= 3.7)
                {
                    aCount++;
                }
                else if (gpa >= 3.0)
                {
                    bCount++;
                }
                else if (gpa >= 2.0)
                {
                    cCount++;
                }
                else
                {
                    dCount++;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("STUDENT COUNTS BY LETTER GRADE");
        Console.WriteLine("A (3.70 and above): " + aCount);
        Console.WriteLine("B (3.00 - 3.69):    " + bCount);
        Console.WriteLine("C (2.00 - 2.99):    " + cCount);
        Console.WriteLine("D (below 2.00):     " + dCount);
    }

    static void ShowAverageGPA(string[] students)
    {
        double totalGPA = 0.0;
        int count = 0;

        foreach (string line in students)
        {
            string id;
            string name;
            double gpa;

            if (TryParseStudent(line, out id, out name, out gpa))
            {
                totalGPA += gpa;
                count++;
            }
        }

        Console.WriteLine();

        if (count == 0)
        {
            Console.WriteLine("No student records found.");
        }
        else
        {
            double averageGPA = totalGPA / count;

            Console.WriteLine(
                "Average GPA: " + averageGPA.ToString("F2")
            );
        }
    }

    static void ShowHighestGPAStudent(string[] students)
    {
        string highestID = "";
        string highestName = "";
        double highestGPA = double.MinValue;
        bool found = false;

        foreach (string line in students)
        {
            string id;
            string name;
            double gpa;

            if (TryParseStudent(line, out id, out name, out gpa))
            {
                if (!found || gpa > highestGPA)
                {
                    highestGPA = gpa;
                    highestID = id;
                    highestName = name;
                    found = true;
                }
            }
        }

        Console.WriteLine();

        if (found)
        {
            Console.WriteLine("HIGHEST GPA STUDENT");
            Console.WriteLine("Student ID: " + highestID);
            Console.WriteLine("Name: " + highestName);
            Console.WriteLine("GPA: " + highestGPA.ToString("F2"));
        }
        else
        {
            Console.WriteLine("No student records found.");
        }
    }
}