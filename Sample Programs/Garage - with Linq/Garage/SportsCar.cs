using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage
{
    sealed class SportsCar : Car
    {
        // Sports car contains a radio and has an insurance loading

        private Radio radio;
        decimal insuranceLoading;


        public SportsCar(string makeIn, string modelIn, string colourIn,
                                       string bodyTypeIn, Radio radioIn)
            : base(makeIn, modelIn, colourIn, bodyTypeIn)
        {
            // all sports cars have an insurance loading and a radio
            InsuranceLoading = 1000;
            radio = radioIn;
        }

        public decimal InsuranceLoading
        {
            get { return this.insuranceLoading; }
            set { this.insuranceLoading = value; }
        }
        public Radio CarRadio
        {   // I am using public properties of the Radio to make it visible
            get { return this.radio; }
            set { this.radio = value; }
        }
        public override string ToString()
        {
            // SportsCar is a car with a radio
            return base.ToString() + "    " + this.radio.Make + "   "+ this.insuranceLoading;
        }
    }
}
