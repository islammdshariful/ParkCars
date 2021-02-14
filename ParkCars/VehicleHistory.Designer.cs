namespace ParkCars
{
    partial class VehicleHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VehileHistoryTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ChooseTime = new System.Windows.Forms.DateTimePicker();
            this.SearchBySlotTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FindByVehicleIDTExtBox = new System.Windows.Forms.TextBox();
            this.FindByUserIDTExtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimePickerOne = new System.Windows.Forms.DateTimePicker();
            this.TimePickerTwo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VehileHistoryTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehileHistoryTable
            // 
            this.VehileHistoryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VehileHistoryTable.BackgroundColor = System.Drawing.Color.White;
            this.VehileHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehileHistoryTable.Location = new System.Drawing.Point(0, 81);
            this.VehileHistoryTable.Name = "VehileHistoryTable";
            this.VehileHistoryTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VehileHistoryTable.Size = new System.Drawing.Size(875, 496);
            this.VehileHistoryTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TimePickerTwo);
            this.panel1.Controls.Add(this.TimePickerOne);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ChooseTime);
            this.panel1.Controls.Add(this.SearchBySlotTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FindByVehicleIDTExtBox);
            this.panel1.Controls.Add(this.FindByUserIDTExtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VehileHistoryTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 577);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(431, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "For Slot Information";
            // 
            // ChooseTime
            // 
            this.ChooseTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseTime.CustomFormat = "MM/dd/yyyy h:mm tt";
            this.ChooseTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ChooseTime.Location = new System.Drawing.Point(243, 32);
            this.ChooseTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseTime.Name = "ChooseTime";
            this.ChooseTime.Size = new System.Drawing.Size(144, 20);
            this.ChooseTime.TabIndex = 9;
            this.ChooseTime.Visible = false;
            this.ChooseTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchSlotInformation);
            // 
            // SearchBySlotTextBox
            // 
            this.SearchBySlotTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBySlotTextBox.BackColor = System.Drawing.Color.White;
            this.SearchBySlotTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBySlotTextBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBySlotTextBox.Location = new System.Drawing.Point(542, 17);
            this.SearchBySlotTextBox.Name = "SearchBySlotTextBox";
            this.SearchBySlotTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchBySlotTextBox.Size = new System.Drawing.Size(142, 13);
            this.SearchBySlotTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(431, 54);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose Time:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(431, 17);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Slot Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "For Vehicle Information";
            // 
            // FindByVehicleIDTExtBox
            // 
            this.FindByVehicleIDTExtBox.BackColor = System.Drawing.Color.White;
            this.FindByVehicleIDTExtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindByVehicleIDTExtBox.ForeColor = System.Drawing.Color.Black;
            this.FindByVehicleIDTExtBox.Location = new System.Drawing.Point(106, 54);
            this.FindByVehicleIDTExtBox.Name = "FindByVehicleIDTExtBox";
            this.FindByVehicleIDTExtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FindByVehicleIDTExtBox.Size = new System.Drawing.Size(118, 13);
            this.FindByVehicleIDTExtBox.TabIndex = 4;
            this.FindByVehicleIDTExtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindByVehicleID);
            // 
            // FindByUserIDTExtBox
            // 
            this.FindByUserIDTExtBox.BackColor = System.Drawing.Color.White;
            this.FindByUserIDTExtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindByUserIDTExtBox.ForeColor = System.Drawing.Color.Black;
            this.FindByUserIDTExtBox.Location = new System.Drawing.Point(106, 17);
            this.FindByUserIDTExtBox.Name = "FindByUserIDTExtBox";
            this.FindByUserIDTExtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FindByUserIDTExtBox.Size = new System.Drawing.Size(118, 13);
            this.FindByUserIDTExtBox.TabIndex = 3;
            this.FindByUserIDTExtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindByUSerID);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Vehicle ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter ID : ";
            // 
            // TimePickerOne
            // 
            this.TimePickerOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePickerOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimePickerOne.CustomFormat = "MM/dd/yyyy h:mm tt";
            this.TimePickerOne.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickerOne.Location = new System.Drawing.Point(540, 52);
            this.TimePickerOne.Margin = new System.Windows.Forms.Padding(2);
            this.TimePickerOne.Name = "TimePickerOne";
            this.TimePickerOne.Size = new System.Drawing.Size(144, 20);
            this.TimePickerOne.TabIndex = 11;
            // 
            // TimePickerTwo
            // 
            this.TimePickerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePickerTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimePickerTwo.CustomFormat = "MM/dd/yyyy h:mm tt";
            this.TimePickerTwo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickerTwo.Location = new System.Drawing.Point(720, 52);
            this.TimePickerTwo.Margin = new System.Windows.Forms.Padding(2);
            this.TimePickerTwo.Name = "TimePickerTwo";
            this.TimePickerTwo.Size = new System.Drawing.Size(144, 20);
            this.TimePickerTwo.TabIndex = 12;
            this.TimePickerTwo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchSlotInfo);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(689, 58);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "TO";
            // 
            // VehicleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "VehicleHistory";
            this.Size = new System.Drawing.Size(875, 577);
            ((System.ComponentModel.ISupportInitialize)(this.VehileHistoryTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VehileHistoryTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindByVehicleIDTExtBox;
        private System.Windows.Forms.TextBox FindByUserIDTExtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBySlotTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ChooseTime;
        private System.Windows.Forms.DateTimePicker TimePickerTwo;
        private System.Windows.Forms.DateTimePicker TimePickerOne;
        private System.Windows.Forms.Label label7;
    }
}
