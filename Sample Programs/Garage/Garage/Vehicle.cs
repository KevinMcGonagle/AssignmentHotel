using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Vehicle
    {
        #region  Fields
        // these fields are private to this class

        private readonly string make;
        private readonly string model;
        private string colour;

        #endregion

        #region constructors
        public Vehicle(string makeIn, string modelIn, string colourIn)
        {
            make = makeIn;
            model = modelIn;
            colour = colourIn;
        }
        //public Vehicle()
        //{
        //    // In reality I should not allow a default vehicle to be created.
        //    // because the other readonly fields can never be set after
        //    // the vehicle is instantiated.
        //  I am going to remove all default constructors

        //}
        #endregion

        #region public Properties

        public string Make   // readonly 
        {
            get { return this.make; }
        }
        public string Model  // readonly
        {
            get { return this.model; }
        }

        public string Colour    // read/write
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        #endregion
        #region Methods
        // This is the base class 
        // By default the name of an object appears when 
        // adding it to a listbox etc
        // override allows us to modify it so as to do what we want 
        public  override string ToString()
        {

            return this.Make + "   " + this.Model + "   "
                + this.Colour;
        }


              #endregion



    }
}
