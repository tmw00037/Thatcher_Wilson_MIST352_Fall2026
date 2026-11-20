using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    internal class Owner
    {
        //Fields
        private string name;
        private string phone;

        //Constructors
        public Owner()
        {
            this.name = "Unknown";
            this.phone = "Not provided";
        }

        public Owner(string theName, string thePhone)
        {
            this.name = "Unknown";          
            this.phone = "Not provided";
            SetName(theName);               
            SetPhone(thePhone);
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

        public string GetPhone()
        {
            return this.phone;
        }

        public void SetPhone(string thePhone)
        {
            if (!string.IsNullOrWhiteSpace(thePhone))
            {
                this.phone = thePhone;
            }
        }

        public string BuildContactCard()
        {
            return $"{this.name} — {this.phone}";
        }

        public bool MatchesPhone(string searchPhone)
        {
            return this.phone == searchPhone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(BuildContactCard());
        }
    }



}
