using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Car : Vehicle
    {
        // car is a specialised vehicle with a bodytype
        // Notice also, that I am using a static counter for 
        //carsInStock - this is instanciated only once
        // Creating a car will increase this stock
        // bodytype is what distingushes a car

        private readonly string bodyType;
        static int carsInStock = 0;

        public Car(string makeIn, string modelIn,
            string colourIn, string bodyTypeIn)
            : base(makeIn, modelIn, colourIn)
        {
            bodyType = bodyTypeIn;
            carsInStock++;
        }

        //public Car()- I am doing away with the default constructor
        // in other words I have decided that we will not have a car 
        // with no details other than its Bodytype
        //{
        //    bodyType = "Saloon";
        //}
        public string BodyType
        {
            get { return this.bodyType; }
        }

        public static int CarsInStock()
        {
            return carsInStock;
        }
        public override string ToString()
        {
            // Get some details from the base class and 
            // add details specific to this class
            // namely BodyType and CarsInStock

     return base.ToString() + "  " + this.BodyType;


        }


       
    }
}
