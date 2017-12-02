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
            Vehicle myVehicle = new Vehicle("Ford", "Focus", "Red");
            Vehicle currentVehicle = myVehicle;
            lstDisplay.Items.Add(currentVehicle);
        }
    }
}
