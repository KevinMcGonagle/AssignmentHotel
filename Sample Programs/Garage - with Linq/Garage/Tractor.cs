using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Tractor : Vehicle
    {
        public Tractor(string makeIn, string modelIn,
            string colourIn, int horsePowerIn)
            : base(makeIn, modelIn, colourIn)
        {
            HorsePower = horsePowerIn;

        }
        // In C# 3.0 and later, auto-implemented properties make property-declaration 
        //more concise when no additional logic is required in the property 
        //    accessors. They also enable client code to create objects. 
        //    When you declare a property as shown in the following example, 
        //the compiler creates a private, anonymous backing field that can only 
        //    be accessed through the property's get and set accessors.

        // Properties
        public int HorsePower { get; set; }

        // Methods
        public override string ToString()
        {
            // I am again overriding the ToString() method
            // notice that some details are returned from the base class
            // followed by specific info from this class
            return base.ToString() + "     " + this.HorsePower;
        }
    }
}
