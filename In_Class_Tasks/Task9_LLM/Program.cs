/*
 * Thatcher Wilson
 * Section 001 11:30am
 * 11/19/2026
 * Task9_LLM
 * Prompt: I input the entire task instructions as well as the image of the UML class diagram
 * and told it to give me the code. 

*/
using System;

class Owner
{
    private string name;
    private string phone;

    // Default constructor
    public Owner()
    {
        name = "Unknown";
        phone = "Not provided";
    }

    // Parameterized constructor
    public Owner(string name, string phone)
    {
        this.name = "Unknown";
        this.phone = "Not provided";

        SetName(name);
        SetPhone(phone);
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            this.name = name;
        }
    }

    public string GetPhone()
    {
        return phone;
    }

    public void SetPhone(string phone)
    {
        if (!string.IsNullOrWhiteSpace(phone))
        {
            this.phone = phone;
        }
    }

    public string BuildContactCard()
    {
        return name + " — " + phone;
    }

    public bool MatchesPhone(string searchPhone)
    {
        return phone == searchPhone;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Owner Name: " + GetName());
        Console.WriteLine("Owner Phone: " + GetPhone());
    }
}

class Pet
{
    private string name;
    private int age;
    private Owner owner;

    // Default constructor
    public Pet()
    {
        name = "Unnamed";
        age = 0;
        owner = new Owner();
    }

    // Parameterized constructor
    public Pet(string name, int age, Owner owner)
    {
        this.name = "Unnamed";
        this.age = 0;
        this.owner = new Owner();

        SetName(name);
        SetAge(age);
        SetOwner(owner);
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            this.name = name;
        }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int age)
    {
        if (age >= 0 && age <= 30)
        {
            this.age = age;
        }
    }

    public Owner GetOwner()
    {
        return owner;
    }

    public void SetOwner(Owner owner)
    {
        if (owner != null)
        {
            this.owner = owner;
        }
    }

    public void HaveBirthday()
    {
        if (age < 30)
        {
            age++;
        }
    }

    public bool IsSenior()
    {
        return age >= 7;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Pet Name: " + GetName());
        Console.WriteLine("Pet Age: " + GetAge());
        Console.WriteLine("Owner Name: " + GetOwner().GetName());
    }
}

class Appointment
{
    private Pet pet;
    private string appointmentDate;
    private double price;

    // Default constructor
    public Appointment()
    {
        pet = new Pet();
        appointmentDate = "Not scheduled";
        price = 0;
    }

    // Parameterized constructor
    public Appointment(Pet pet, string appointmentDate, double price)
    {
        this.pet = new Pet();
        this.appointmentDate = "Not scheduled";
        this.price = 0;

        SetPet(pet);
        SetAppointmentDate(appointmentDate);
        SetPrice(price);
    }

    public Pet GetPet()
    {
        return pet;
    }

    public void SetPet(Pet pet)
    {
        if (pet != null)
        {
            this.pet = pet;
        }
    }

    public string GetAppointmentDate()
    {
        return appointmentDate;
    }

    public void SetAppointmentDate(string appointmentDate)
    {
        if (!string.IsNullOrWhiteSpace(appointmentDate))
        {
            this.appointmentDate = appointmentDate;
        }
    }

    public double GetPrice()
    {
        return price;
    }

    public void SetPrice(double price)
    {
        if (price >= 0)
        {
            this.price = price;
        }
    }

    public void ApplyDiscount(double percent)
    {
        if (percent >= 0 && percent <= 50)
        {
            price = price - (price * percent / 100);
        }
    }

    public double CalculateDeposit()
    {
        return price * 0.25;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Pet Name: " + GetPet().GetName());
        Console.WriteLine("Appointment Date: " + GetAppointmentDate());
        Console.WriteLine("Price: $" + GetPrice().ToString("F2"));
    }
}

class Program
{
    /*
     * AI/LLM USED: ChatGPT (GPT-6)
     *
     * EXACT PROMPT:
     * Create a C# Pet Grooming System based on the provided UML
     * class diagram and assignment instructions.
     *
     * Create three classes: Owner, Pet, and Appointment.
     * Include all required private fields, default constructors,
     * parameterized constructors, getters, setters, validation,
     * and DisplayInfo methods.
     *
     * Parameterized constructors must first establish default
     * values and then use setters to apply the supplied values.
     *
     * Owner must include BuildContactCard and MatchesPhone.
     * Pet must include HaveBirthday and IsSenior.
     * Appointment must include ApplyDiscount and CalculateDeposit.
     *
     * Follow all validation rules in the assignment. Invalid
     * setter values must leave the stored value unchanged.
     *
     * In Main, create three owners, three pets, and three
     * appointments using both constructor types. Connect the
     * objects, demonstrate setters and additional methods,
     * attempt invalid updates, and display all nine objects.
     */

    static void Main(string[] args)
    {
        // Create three owners using both constructors
        Owner owner1 = new Owner();

        owner1.SetName("Alex");
        owner1.SetPhone("304-555-0101");

        Owner owner2 = new Owner("Jordan", "304-555-0102");

        Owner owner3 = new Owner("Taylor", "304-555-0103");

        // Create three pets using both constructors
        Pet pet1 = new Pet();

        pet1.SetName("Buddy");
        pet1.SetAge(5);
        pet1.SetOwner(owner1);

        Pet pet2 = new Pet("Max", 9, owner2);

        Pet pet3 = new Pet("Bella", 3, owner3);

        // Create three appointments using both constructors
        Appointment appointment1 = new Appointment();

        appointment1.SetPet(pet1);
        appointment1.SetAppointmentDate("December 2, 2026");
        appointment1.SetPrice(60);

        Appointment appointment2 = new Appointment(
            pet2, "December 5, 2026", 80
        );

        Appointment appointment3 = new Appointment(
            pet3, "December 8, 2026", 45
        );

        // Use setters to update existing information
        owner1.SetPhone("304-555-9999");

        pet2.SetName("Maximus");

        appointment2.SetAppointmentDate("December 10, 2026");

        // Demonstrate Owner additional methods
        Console.WriteLine("OWNER METHODS");

        Console.WriteLine(owner1.BuildContactCard());

        Console.WriteLine(
            "Phone matches: " +
            owner1.MatchesPhone("304-555-9999")
        );

        // Demonstrate Pet additional methods
        Console.WriteLine();
        Console.WriteLine("PET METHODS");

        pet1.HaveBirthday();

        Console.WriteLine(
            pet1.GetName() + "'s new age: " + pet1.GetAge()
        );

        Console.WriteLine(
            pet2.GetName() + " is a senior: " + pet2.IsSenior()
        );

        // Demonstrate Appointment additional methods
        Console.WriteLine();
        Console.WriteLine("APPOINTMENT METHODS");

        appointment1.ApplyDiscount(10);

        Console.WriteLine(
            "Discounted price: $" +
            appointment1.GetPrice().ToString("F2")
        );

        Console.WriteLine(
            "Required deposit: $" +
            appointment1.CalculateDeposit().ToString("F2")
        );

        // Attempt invalid updates
        Console.WriteLine();
        Console.WriteLine("TESTING INVALID UPDATES");

        owner1.SetName("");

        pet1.SetAge(-2);

        appointment1.SetPrice(-10);

        Console.WriteLine("Attempted to set owner name to empty.");
        Console.WriteLine("Attempted to set pet age to -2.");
        Console.WriteLine("Attempted to set appointment price to -10.");

        Console.WriteLine("Invalid updates should not change stored values.");

        // Display all three owners
        Console.WriteLine();
        Console.WriteLine("ALL OWNERS");

        owner1.DisplayInfo();
        Console.WriteLine();

        owner2.DisplayInfo();
        Console.WriteLine();

        owner3.DisplayInfo();

        // Display all three pets
        Console.WriteLine();
        Console.WriteLine("ALL PETS");

        pet1.DisplayInfo();
        Console.WriteLine();

        pet2.DisplayInfo();
        Console.WriteLine();

        pet3.DisplayInfo();

        // Display all three appointments
        Console.WriteLine();
        Console.WriteLine("ALL APPOINTMENTS");

        appointment1.DisplayInfo();
        Console.WriteLine();

        appointment2.DisplayInfo();
        Console.WriteLine();

        appointment3.DisplayInfo();

        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}