using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class frmGarage : Form
    {
        public frmGarage()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            // not really a good idea to add a vehicle
            
            // the following will cause an error "
            // Error CS0144  Cannot create an instance of the abstract class or interface 'Vehicle'	
            //Vehicle myVehicle = new Vehicle("Ford", "Focus", "Red");
            //Vehicle currentVehicle = myVehicle;
            //lstDisplay.Items.Add(currentVehicle);
            MessageBox.Show("Cannot instantiate an abstract Class", "Error");
    }

    private void btnAddCar_Click(object sender, EventArgs e)
        {
            // car is a specialised vehicle in that it
            // has a bodytype. Note that I also decided to keep 
            //track of the number of cars that we add
            // The car will be added to lstDisplay twice using
            // 2 different methods
            Car myCar = new Car("Opel", "Astra", "Blue", "Saloon");
            lstDisplay.Items.Add(myCar);

        }

        private void btnAddSportsCar_Click(object sender, EventArgs e)
        {
            // Instantiate a new radio and create a new sports Car
            Radio aNewRadio = new Radio("Sony");
            SportsCar myDreamCar = new SportsCar("Ferrari", "GT330", "Red", "Coupe", aNewRadio);
            myDreamCar.CarRadio.SwitchOn();
            myDreamCar.CarRadio.Channel = "RTE 1";
            lstDisplay.Items.Add(myDreamCar);
        }

        private void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find out what type of vehicle is selected
            // Display the vehicle type in a messageBox
             Vehicle anotherVehicle = (Vehicle)lstDisplay.SelectedItem;
            Type vehicleType = anotherVehicle.GetType();
            string vehicleName = "This is a type of " + vehicleType.Name;
            MessageBox.Show(vehicleName, "Vehicle type");
                     

        }

     


        private void btnAddTractor_Click(object sender, EventArgs e)
        {
            Tractor anotherTractor = new Tractor("CaseIH", "CX110", "Red", 120);
            lstDisplay.Items.Add(anotherTractor);
        }
    }
}
