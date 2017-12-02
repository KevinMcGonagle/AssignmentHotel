namespace SelectTractorEx
{
    partial class frmListsEtc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoListBox = new System.Windows.Forms.RadioButton();
            this.rdoComboBox = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.cboTractors = new System.Windows.Forms.ComboBox();
            this.lstTractors = new System.Windows.Forms.ListBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoListBox);
            this.groupBox1.Controls.Add(this.rdoComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select  listBox or comboBox";
            // 
            // rdoListBox
            // 
            this.rdoListBox.AutoSize = true;
            this.rdoListBox.Location = new System.Drawing.Point(160, 41);
            this.rdoListBox.Name = "rdoListBox";
            this.rdoListBox.Size = new System.Drawing.Size(59, 17);
            this.rdoListBox.TabIndex = 0;
            this.rdoListBox.TabStop = true;
            this.rdoListBox.Text = "ListBox";
            this.rdoListBox.UseVisualStyleBackColor = true;
            // 
            // rdoComboBox
            // 
            this.rdoComboBox.AutoSize = true;
            this.rdoComboBox.Location = new System.Drawing.Point(40, 41);
            this.rdoComboBox.Name = "rdoComboBox";
            this.rdoComboBox.Size = new System.Drawing.Size(76, 17);
            this.rdoComboBox.TabIndex = 0;
            this.rdoComboBox.TabStop = true;
            this.rdoComboBox.Text = "ComboBox";
            this.rdoComboBox.UseVisualStyleBackColor = true;
            this.rdoComboBox.CheckedChanged += new System.EventHandler(this.rdoComboBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Delivery Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, -18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select Delivery Date";
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(24, 88);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryDate.TabIndex = 13;
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Location = new System.Drawing.Point(24, 23);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(200, 20);
            this.dtpDelivery.TabIndex = 8;
            this.dtpDelivery.ValueChanged += new System.EventHandler(this.dtpDelivery_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selected Registration Number";
            // 
            // txtRegNum
            // 
            this.txtRegNum.Enabled = false;
            this.txtRegNum.Location = new System.Drawing.Point(12, 345);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.ReadOnly = true;
            this.txtRegNum.Size = new System.Drawing.Size(125, 20);
            this.txtRegNum.TabIndex = 11;
            // 
            // cboTractors
            // 
            this.cboTractors.FormattingEnabled = true;
            this.cboTractors.Location = new System.Drawing.Point(12, 266);
            this.cboTractors.Name = "cboTractors";
            this.cboTractors.Size = new System.Drawing.Size(202, 21);
            this.cboTractors.Sorted = true;
            this.cboTractors.TabIndex = 10;
            this.cboTractors.Text = "Sorted Regs";
            this.cboTractors.SelectedIndexChanged += new System.EventHandler(this.cboTractors_SelectedIndexChanged);
            // 
            // lstTractors
            // 
            this.lstTractors.FormattingEnabled = true;
            this.lstTractors.Location = new System.Drawing.Point(12, 121);
            this.lstTractors.Name = "lstTractors";
            this.lstTractors.Size = new System.Drawing.Size(310, 108);
            this.lstTractors.TabIndex = 9;
            this.lstTractors.SelectedIndexChanged += new System.EventHandler(this.lstTractors_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(380, 345);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(71, 20);
            this.txtPrice.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDeliveryDate);
            this.groupBox2.Controls.Add(this.dtpDelivery);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(525, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 125);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Delivery Date";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(158, 345);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(106, 20);
            this.txtMake.TabIndex = 16;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(268, 345);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(106, 20);
            this.txtModel.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Price";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(525, 200);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(270, 72);
            this.txtDisplay.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(578, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 34);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Find Tractor by REgistration Number";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(277, 267);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(179, 20);
            this.txtQuery.TabIndex = 24;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(279, 295);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(171, 25);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // frmListsEtc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 420);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegNum);
            this.Controls.Add(this.cboTractors);
            this.Controls.Add(this.lstTractors);
            this.Name = "frmListsEtc";
            this.Text = "Cyril Higgins- Lists etc";
            this.Load += new System.EventHandler(this.frmListsEtc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoListBox;
        private System.Windows.Forms.RadioButton rdoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.ComboBox cboTractors;
        private System.Windows.Forms.ListBox lstTractors;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnFind;
    }
}