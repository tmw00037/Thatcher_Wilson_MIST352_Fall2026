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

        // --- clean each part 
            strPart1 = strPart1.Trim();
            strPart2 = strPart2.Trim();
            strPart3 = strPart3.Trim();
            strPart4 = strPart4.Trim();
            strPart5 = strPart5.Trim();

        //extract everything 
            string location = strPart2.Replace("Location:", "").Trim();
            string timeText = strPart3.Replace("Time:", "").Trim();
            string pillChoice = strPart5.Replace("Pill:", "").Trim().ToLower();
            string agentName = strPart1.Split(',')[1].Trim();

            string codeRaw = strPart4.Replace("Code:", "").Replace("#", "").Trim();
            string codeNumberPart = codeRaw.Split('-')[1];
            int codeNumber = int.Parse(codeNumberPart);
        //output
            Console.WriteLine($"Alert:{strPart1.ToUpper().Replace(", ",",")}");
            Console.WriteLine($"Agent:{strPart1.Split(',')[1]}");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Time: {timeText}");
            Console.WriteLine($"Pill: {pillChoice}");
            Console.WriteLine($"Code number parsed: {codeNumber}");
            Console.WriteLine($"Agent name length: {agentName.Length}");

            bool locationHasI = location.ToLower().Contains("i");
            Console.WriteLine($"Location contains 'i' (case-insensitive): {locationHasI}");
    


        }
   }

