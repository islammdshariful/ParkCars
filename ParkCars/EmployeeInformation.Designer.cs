namespace ParkCars
{
    partial class EmployeeInformation
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
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeAddressTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmployeePasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeGenderTextBox = new System.Windows.Forms.TextBox();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.UserPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTable.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTable.Location = new System.Drawing.Point(2, 15);
            this.EmployeeTable.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.RowTemplate.Height = 24;
            this.EmployeeTable.Size = new System.Drawing.Size(871, 286);
            this.EmployeeTable.TabIndex = 0;
            this.EmployeeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEE INFORMATION";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email Address : ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 498);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender : ";
            // 
            // EmployeeUsernameTextBox
            // 
            this.EmployeeUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeUsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.EmployeeUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeUsernameTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeUsernameTextBox.Location = new System.Drawing.Point(436, 339);
            this.EmployeeUsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeUsernameTextBox.Name = "EmployeeUsernameTextBox";
            this.EmployeeUsernameTextBox.Size = new System.Drawing.Size(151, 13);
            this.EmployeeUsernameTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(368, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username : ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(368, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password : ";
            // 
            // EmployeeAddressTextBox
            // 
            this.EmployeeAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.EmployeeAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeAddressTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeAddressTextBox.Location = new System.Drawing.Point(436, 450);
            this.EmployeeAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeAddressTextBox.Multiline = true;
            this.EmployeeAddressTextBox.Name = "EmployeeAddressTextBox";
            this.EmployeeAddressTextBox.Size = new System.Drawing.Size(151, 67);
            this.EmployeeAddressTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(368, 447);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address : ";
            // 
            // EmployeePasswordTextBox
            // 
            this.EmployeePasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeePasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.EmployeePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeePasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeePasswordTextBox.Location = new System.Drawing.Point(436, 390);
            this.EmployeePasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeePasswordTextBox.Name = "EmployeePasswordTextBox";
            this.EmployeePasswordTextBox.Size = new System.Drawing.Size(151, 13);
            this.EmployeePasswordTextBox.TabIndex = 16;
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.EmployeeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeNameTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(129, 389);
            this.EmployeeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(151, 13);
            this.EmployeeNameTextBox.TabIndex = 17;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.EmployeeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeIDTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(129, 339);
            this.EmployeeIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.ReadOnly = true;
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(151, 13);
            this.EmployeeIDTextBox.TabIndex = 18;
            // 
            // EmployeeEmailAddressTextBox
            // 
            this.EmployeeEmailAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeEmailAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.EmployeeEmailAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeEmailAddressTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeEmailAddressTextBox.Location = new System.Drawing.Point(129, 450);
            this.EmployeeEmailAddressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeEmailAddressTextBox.Name = "EmployeeEmailAddressTextBox";
            this.EmployeeEmailAddressTextBox.Size = new System.Drawing.Size(151, 13);
            this.EmployeeEmailAddressTextBox.TabIndex = 19;
            // 
            // EmployeeGenderTextBox
            // 
            this.EmployeeGenderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeGenderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.EmployeeGenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeGenderTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeGenderTextBox.Location = new System.Drawing.Point(129, 498);
            this.EmployeeGenderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeGenderTextBox.Name = "EmployeeGenderTextBox";
            this.EmployeeGenderTextBox.Size = new System.Drawing.Size(151, 13);
            this.EmployeeGenderTextBox.TabIndex = 20;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(687, 493);
            this.DeleteEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(56, 27);
            this.DeleteEmployeeButton.TabIndex = 21;
            this.DeleteEmployeeButton.Text = "Delete";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(765, 493);
            this.UpdateEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(56, 25);
            this.UpdateEmployeeButton.TabIndex = 22;
            this.UpdateEmployeeButton.Text = "Update";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = false;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // UserPhoto
            // 
            this.UserPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPhoto.BackgroundImage = global::ParkCars.Properties.Resources.man_user__1_;
            this.UserPhoto.Location = new System.Drawing.Point(687, 339);
            this.UserPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.Size = new System.Drawing.Size(134, 128);
            this.UserPhoto.TabIndex = 23;
            this.UserPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmployeeGenderTextBox);
            this.panel1.Controls.Add(this.UserPhoto);
            this.panel1.Controls.Add(this.EmployeeEmailAddressTextBox);
            this.panel1.Controls.Add(this.UpdateEmployeeButton);
            this.panel1.Controls.Add(this.EmployeeIDTextBox);
            this.panel1.Controls.Add(this.EmployeeNameTextBox);
            this.panel1.Controls.Add(this.EmployeeTable);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DeleteEmployeeButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmployeePasswordTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmployeeUsernameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmployeeAddressTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 577);
            this.panel1.TabIndex = 24;
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeInformation";
            this.Size = new System.Drawing.Size(875, 577);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmployeeUsernameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmployeeAddressTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmployeePasswordTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox EmployeeEmailAddressTextBox;
        private System.Windows.Forms.TextBox EmployeeGenderTextBox;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.PictureBox UserPhoto;
        private System.Windows.Forms.Panel panel1;
    }
}
