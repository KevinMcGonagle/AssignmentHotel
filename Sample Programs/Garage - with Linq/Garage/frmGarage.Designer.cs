namespace Garage
{
    partial class frmGarage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnAddSportsCar = new System.Windows.Forms.Button();
            this.btnAddTractor = new System.Windows.Forms.Button();
            this.btnShowCars = new System.Windows.Forms.Button();
            this.btnShowTractors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(39, 103);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(133, 32);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(39, 15);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(211, 69);
            this.lstDisplay.TabIndex = 1;
            this.lstDisplay.SelectedIndexChanged += new System.EventHandler(this.lstDisplay_SelectedIndexChanged);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(39, 156);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(133, 32);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnAddSportsCar
            // 
            this.btnAddSportsCar.Location = new System.Drawing.Point(39, 209);
            this.btnAddSportsCar.Name = "btnAddSportsCar";
            this.btnAddSportsCar.Size = new System.Drawing.Size(133, 32);
            this.btnAddSportsCar.TabIndex = 3;
            this.btnAddSportsCar.Text = "Add Sports Car";
            this.btnAddSportsCar.UseVisualStyleBackColor = true;
            this.btnAddSportsCar.Click += new System.EventHandler(this.btnAddSportsCar_Click);
            // 
            // btnAddTractor
            // 
            this.btnAddTractor.Location = new System.Drawing.Point(39, 265);
            this.btnAddTractor.Name = "btnAddTractor";
            this.btnAddTractor.Size = new System.Drawing.Size(133, 32);
            this.btnAddTractor.TabIndex = 5;
            this.btnAddTractor.Text = "Add Tractor";
            this.btnAddTractor.UseVisualStyleBackColor = true;
            this.btnAddTractor.Click += new System.EventHandler(this.btnAddTractor_Click);
            // 
            // btnShowCars
            // 
            this.btnShowCars.Location = new System.Drawing.Point(313, 156);
            this.btnShowCars.Name = "btnShowCars";
            this.btnShowCars.Size = new System.Drawing.Size(112, 30);
            this.btnShowCars.TabIndex = 6;
            this.btnShowCars.Text = "Show Cars";
            this.btnShowCars.UseVisualStyleBackColor = true;
            this.btnShowCars.Click += new System.EventHandler(this.btnShowCars_Click);
            // 
            // btnShowTractors
            // 
            this.btnShowTractors.Location = new System.Drawing.Point(313, 214);
            this.btnShowTractors.Name = "btnShowTractors";
            this.btnShowTractors.Size = new System.Drawing.Size(112, 27);
            this.btnShowTractors.TabIndex = 7;
            this.btnShowTractors.Text = "ShowTractors";
            this.btnShowTractors.UseVisualStyleBackColor = true;
            this.btnShowTractors.Click += new System.EventHandler(this.btnShowTractors_Click);
            // 
            // frmGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 442);
            this.Controls.Add(this.btnShowTractors);
            this.Controls.Add(this.btnShowCars);
            this.Controls.Add(this.btnAddTractor);
            this.Controls.Add(this.btnAddSportsCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnAddVehicle);
            this.Name = "frmGarage";
            this.Text = "Garage V1- Cyril Higgins";
            this.Load += new System.EventHandler(this.frmGarage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnAddSportsCar;
        private System.Windows.Forms.Button btnAddTractor;
        private System.Windows.Forms.Button btnShowCars;
        private System.Windows.Forms.Button btnShowTractors;
    }
}

