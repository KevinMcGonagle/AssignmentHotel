using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{

    public class Vehicle
    {
        #region private Fields
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
        public Vehicle()
        {
            // In reality I should not allow a default vehicle to be created.
            // because the other readonly fields can never be set after
            // the vehicle is instantiated.

        }
        #endregion

        #region public Properties
        public int Speed { get; set; }

        public string Make   // readonly 
        {
            get { return this.make; }
        }
        public string Model  // readonly
        {
            get { return this.model; }
        }

        public string Colour    // readonly
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        #endregion
        #region Methods
        public override string ToString()
        {

            return this.Make + "   " + this.Model + "   " + this.Colour + this.Speed;
        }
        #endregion
       


    }
}
