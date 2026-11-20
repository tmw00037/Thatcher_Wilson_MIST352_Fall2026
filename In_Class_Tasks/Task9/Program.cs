/*
 * Thatcher Wilson
 * Section 001 11:30am
 * 11/19/2026
 * Task9
*/
namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Owner o1 = new Owner();
            Owner o2 = new Owner("Sarah Conor", "555-55-5555");
            Owner o3 = new Owner("Alex", "304-555-0101");
            o1.SetName("Thatcher");
            o1.SetPhone("304-555-0000");

            
            Pet p1 = new Pet();
            Pet p2 = new Pet("Fluffkinz", 3, o2);
            Pet p3 = new Pet("Max", 9, o3);
            p1.SetName("Buddy");
            p1.SetAge(5);
            p1.SetOwner(o1);

            
            Appointment a1 = new Appointment();
            Appointment a2 = new Appointment(p2, "December 2, 2026", 60);
            Appointment a3 = new Appointment(p3, "December 5, 2026", 80);
            a1.SetPet(p1);
            a1.SetAppointmentDate("December 1, 2026");
            a1.SetPrice(50);

            
            o2.SetPhone("304-555-9999");
            p2.SetName("Fluffy");
            a3.SetAppointmentDate("December 9, 2026");

            
            Console.WriteLine(o2.BuildContactCard());
            Console.WriteLine($"Matches 304-555-9999? {o2.MatchesPhone("304-555-9999")}");
            Console.WriteLine($"Matches 000? {o2.MatchesPhone("000")}");

            p3.HaveBirthday();
            Console.WriteLine($"{p3.GetName()} is now {p3.GetAge()}");
            Console.WriteLine($"{p3.GetName()} senior? {p3.IsSenior()}");
            Console.WriteLine($"{p1.GetName()} senior? {p1.IsSenior()}");

            a2.ApplyDiscount(10);
            Console.WriteLine($"Price after 10% discount: ${a2.GetPrice():F2}");
            Console.WriteLine($"Deposit: ${a2.CalculateDeposit():F2}");

            
            o3.SetName("");
            p2.SetAge(-2);
            a3.SetPrice(-10);

            
            Console.WriteLine();
            o1.DisplayInfo(); o2.DisplayInfo(); o3.DisplayInfo();
            p1.DisplayInfo(); p2.DisplayInfo(); p3.DisplayInfo();
            a1.DisplayInfo(); a2.DisplayInfo(); a3.DisplayInfo();
        }
    }
}
