using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectTractorEx
{
    public partial class frmListsEtc : Form
    {
        public frmListsEtc()
        {
            InitializeComponent();
        }
        List<Tractor> garage = new List<Tractor>();
        private void frmListsEtc_Load(object sender, EventArgs e)
        {

            Tractor t1 = new Tractor("88MO1244", "Ford", "4400", 12000);
            Tractor t2 = new Tractor("76DL5555", "Ford", "3600", 14000);
            Tractor t3 = new Tractor("94SO5678", "Massey Ferguson", "365", 5000);
            Tractor t4 = new Tractor("76RN4455", "David Brown", "895", 2500);
            garage.Add(t1);
            garage.Add(t2);
            garage.Add(t3);
            garage.Add(t4);

            // Place each tractor in the garage onto lstTractors ListBox
            foreach (Tractor stockNum in garage)
            {
                lstTractors.Items.Add(stockNum);


            }
        }

        private void lstTractors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lstTractors listbox is an exact representation of my generic
            // tractor list. I will use the index of the selected item
            // to retrieve the tractor object from the generic list.
            // Put the tractor details onto textboxes
            // Will also put the tractor registration number into the combobox cboTractors

            int indexTemp = lstTractors.SelectedIndex;
            Tractor currentTractor = garage.ElementAt(indexTemp);
            cboTractors.Items.Add(currentTractor.RegistrationNumber);
            txtRegNum.Text = currentTractor.RegistrationNumber;
            txtMake.Text = currentTractor.Make;
            txtModel.Text = currentTractor.Model;
            txtPrice.Text = (currentTractor.Price.ToString("c"));
            // highlighting the contains method... 
            if (garage.Contains(currentTractor))
            {
                int whereItis = garage.IndexOf(currentTractor);
                Tractor searchTractor = garage.ElementAt(whereItis);
                // display the tractor
            }
            else
            {
                // not found
            }
        }

        private void dtpDelivery_ValueChanged(object sender, EventArgs e)
        {
            // get the delivery date and cast it to a ShortDateString
            DateTime deliveryDate = dtpDelivery.Value;
            txtDeliveryDate.Text = deliveryDate.ToShortDateString();

            DateTime startDate = new DateTime(2012, 2, 29);
            Console.WriteLine("She began work in the year {0}", startDate.Year);
            DateTime currentDateTime = DateTime.Now;
            DateTime currentDate = DateTime.Today;
            string dateLongVersion = currentDate.ToLongDateString();
            if (DateTime.IsLeapYear(currentDate.Year))
            {
                txtDisplay.Text += currentDate.Year + " is a leap year ***";
            }
            DateTime workStartDate = new DateTime(2012, 2, 29);
            TimeSpan yearsWorking = currentDate.Subtract(workStartDate);
            int years = yearsWorking.Days / 365;
            txtDisplay.Text += "She bagan work in the year " + workStartDate.Year + "****";
            txtDisplay.Text += "She has worked a total of " + years + "years";




        }

        private void rdoComboBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoComboBox.Checked == true)
            {
                lstTractors.Enabled = false;
            }
            else
            {
                lstTractors.Enabled = true;
            }
        }

        private void cboTractors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryReg = cboTractors.Text;
            foreach (Tractor currentTractor in garage)
            {
                if (currentTractor.RegistrationNumber == queryReg)
                {
                    // found the tractor (Registration Number is unique)
                    txtRegNum.Text = currentTractor.RegistrationNumber;
                    txtMake.Text = currentTractor.Make;
                    txtModel.Text = currentTractor.Model;
                    txtPrice.Text = (currentTractor.Price.ToString("c"));

                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtRegNum.Text = "";
            txtMake.Clear();
            txtModel.Clear();
            txtPrice.Text = "";
            string queryReg = txtQuery.Text;
            foreach (Tractor currentTractor in garage)
            {
                if (currentTractor.RegistrationNumber == queryReg)
                {
                    // found the tractor (Registration Number is unique)
                    txtRegNum.Text = currentTractor.RegistrationNumber;
                    txtMake.Text = currentTractor.Make;
                    txtModel.Text = currentTractor.Model;
                    txtPrice.Text = (currentTractor.Price.ToString("c"));

                }
            }
        }
    }
}
