using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    internal class Pet
    {
        private string name;
        private int age;
        private Owner owner;

        //Constructors
        public Pet()
        {
            this.name = "Unnamed";
            this.age = 0;
            this.owner = new Owner();
        }

        public Pet(string theName, int theAge, Owner theOwner)
        {
            this.name = "Unnamed";
            this.age = 0;
            this.owner = new Owner();
            SetName(theName);
            SetAge(theAge);
            SetOwner(theOwner);
        }

        //Methods
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string theName)
        {
            if (!string.IsNullOrWhiteSpace(theName))
            {
                this.name = theName;
            }
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int theAge)
        {
            if (theAge >= 0 && theAge <= 30)
            {
                this.age = theAge;
            }
        }

        public Owner GetOwner()
        {
            return this.owner;
        }

        public void SetOwner(Owner theOwner)
        {
            if (theOwner != null)
            {
                this.owner = theOwner;
            }
        }

        public void HaveBirthday()
        {
            if (this.age < 30)
            {
                this.age++;
            }
        }

        public bool IsSenior()
        {
            return this.age >= 7;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{this.name} == {this.age} == Owner: {this.owner.GetName()}");
        }
    }
}
