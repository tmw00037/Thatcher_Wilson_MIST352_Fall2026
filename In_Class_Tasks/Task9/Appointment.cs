using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    internal class Appointment
    {
        private Pet pet;
        private string appointmentDate;
        private double price;

        //Constructors
        public Appointment()
        {
            this.pet = new Pet();
            this.appointmentDate = "Not scheduled";
            this.price = 0;
        }

        public Appointment(Pet thePet, string theDate, double thePrice)
        {
            this.pet = new Pet();
            this.appointmentDate = "Not scheduled";
            this.price = 0;
            SetPet(thePet);
            SetAppointmentDate(theDate);
            SetPrice(thePrice);
        }

        //Methods
        public Pet GetPet()
        {
            return this.pet;
        }

        public void SetPet(Pet thePet)
        {
            if (thePet != null)
            {
                this.pet = thePet;
            }
        }

        public string GetAppointmentDate()
        {
            return this.appointmentDate;
        }

        public void SetAppointmentDate(string theDate)
        {
            if (!string.IsNullOrWhiteSpace(theDate))
            {
                this.appointmentDate = theDate;
            }
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetPrice(double thePrice)
        {
            if (thePrice >= 0)
            {
                this.price = thePrice;
            }
        }

        public void ApplyDiscount(double percent)
        {
            if (percent >= 0 && percent <= 50)
            {
                this.price = this.price - (this.price * percent / 100);
            }
        }

        public double CalculateDeposit()
        {
            return this.price * 0.25;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{this.pet.GetName()} -- {this.appointmentDate} -- ${this.price:F2}");
        }
    }
}
