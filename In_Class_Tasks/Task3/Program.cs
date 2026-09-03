using System;
/*
     * Name: Thatcher Wilson
     * Section: 001 at 11:30 AM
     * Assesment: Task3
     * Date: 09/03/2026
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            string strMsg = "WAKE UP, Neo | Location: Zion | Time: 07:45 PM | Code: #NEO-7 | Pill: Red";
            string[] splittedMsg = strMsg.Split('|');
            string strPart1 = splittedMsg[0];
            string strPart2 = splittedMsg[1];
            string strPart3 = splittedMsg[2];
            string strPart4 = splittedMsg[3];
            string strPart5 = splittedMsg[4];
            Console.WriteLine($"Alert:{strPart1.ToUpper().Replace(", ",",")}");
            Console.WriteLine($"Agent:{strPart1.Split(',')[1]}");

        }
   }

