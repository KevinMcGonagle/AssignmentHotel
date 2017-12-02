using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Radio
    {   // private Fields
        string make;
        string currentChannel;
        Boolean switchedOn = false;

        // Constructors
        public Radio()
        {   // Radios are Sony by default
            make = "Sony";
        }

        public Radio(string makeIn)
        {
            make = makeIn;
         }
        
        // Properties
        public string Channel
        {
            get
            {
                if (switchedOn == true)
                    return this.currentChannel;
                else
                { return "Radio is switched off"; }
            }
            set
            {
                if (switchedOn == true)

                    this.currentChannel = value;
            }
        }
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        // methods
        public void SwitchOn()
        { this.switchedOn = true; }
        public void SwitchOff()
        { this.switchedOn = false; }
    }
}
