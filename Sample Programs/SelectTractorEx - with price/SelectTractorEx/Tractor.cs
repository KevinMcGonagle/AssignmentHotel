using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectTractorEx
{
    class Tractor
    {

        private string registrationNumber;

        private string make;
        private string model;
        private decimal price;

        public Tractor()
        {
            
        }
        public Tractor(string registrationNumber, string make, string model, decimal price)
        {
            this.RegistrationNumber = registrationNumber;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
        // the keyword 'this' is referring to the current object.
        // it can be left out if one wishes
        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                this.registrationNumber = value;
            }
        }


        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }


        //      We need to override  'ToString'  so as to get the object content as opposed to its name!
        public override string ToString()
        {
            return this.RegistrationNumber + "\t " + this.Make + "\t" + this.Model + "\t" + this.Price;
         
        }

    }
}
