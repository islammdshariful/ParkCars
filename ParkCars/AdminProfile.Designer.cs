namespace ParkCars
{
    partial class AdminProfile
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
            this.PersonProfileWindow = new System.Windows.Forms.Panel();
            this.PersonName = new System.Windows.Forms.TextBox();
            this.PersonEmailAddress = new System.Windows.Forms.TextBox();
            this.PersonUsername = new System.Windows.Forms.TextBox();
            this.PersonID = new System.Windows.Forms.TextBox();
            this.Setting = new System.Windows.Forms.PictureBox();
            this.PersonAddress = new System.Windows.Forms.TextBox();
            this.UserPhoto = new System.Windows.Forms.PictureBox();
            this.PersonProfileWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonProfileWindow
            // 
            this.PersonProfileWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.PersonProfileWindow.Controls.Add(this.PersonName);
            this.PersonProfileWindow.Controls.Add(this.PersonEmailAddress);
            this.PersonProfileWindow.Controls.Add(this.PersonUsername);
            this.PersonProfileWindow.Controls.Add(this.PersonID);
            this.PersonProfileWindow.Controls.Add(this.Setting);
            this.PersonProfileWindow.Controls.Add(this.PersonAddress);
            this.PersonProfileWindow.Controls.Add(this.UserPhoto);
            this.PersonProfileWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonProfileWindow.Location = new System.Drawing.Point(0, 0);
            this.PersonProfileWindow.Name = "PersonProfileWindow";
            this.PersonProfileWindow.Size = new System.Drawing.Size(875, 577);
            this.PersonProfileWindow.TabIndex = 39;
            // 
            // PersonName
            // 
            this.PersonName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.PersonName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonName.ForeColor = System.Drawing.Color.White;
            this.PersonName.Location = new System.Drawing.Point(237, 222);
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Size = new System.Drawing.Size(352, 24);
            this.PersonName.TabIndex = 42;
            this.PersonName.Text = "Md. Shariful Islam Sabbir";
            this.PersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonEmailAddress
            // 
            this.PersonEmailAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.PersonEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonEmailAddress.ForeColor = System.Drawing.Color.White;
            this.PersonEmailAddress.Location = new System.Drawing.Point(319, 352);
            this.PersonEmailAddress.Multiline = true;
            this.PersonEmailAddress.Name = "PersonEmailAddress";
            this.PersonEmailAddress.ReadOnly = true;
            this.PersonEmailAddress.Size = new System.Drawing.Size(195, 20);
            this.PersonEmailAddress.TabIndex = 41;
            this.PersonEmailAddress.Text = "Email Address";
            this.PersonEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonUsername
            // 
            this.PersonUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.PersonUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonUsername.ForeColor = System.Drawing.Color.White;
            this.PersonUsername.Location = new System.Drawing.Point(319, 300);
            this.PersonUsername.Multiline = true;
            this.PersonUsername.Name = "PersonUsername";
            this.PersonUsername.ReadOnly = true;
            this.PersonUsername.Size = new System.Drawing.Size(195, 20);
            this.PersonUsername.TabIndex = 40;
            this.PersonUsername.Text = "Username";
            this.PersonUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonID
            // 
            this.PersonID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.PersonID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonID.ForeColor = System.Drawing.Color.White;
            this.PersonID.Location = new System.Drawing.Point(319, 252);
            this.PersonID.Multiline = true;
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Size = new System.Drawing.Size(195, 20);
            this.PersonID.TabIndex = 39;
            this.PersonID.Text = "ID";
            this.PersonID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Setting
            // 
            this.Setting.BackgroundImage = global::ParkCars.Properties.Resources.settings;
            this.Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Setting.Location = new System.Drawing.Point(655, 222);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(24, 24);
            this.Setting.TabIndex = 38;
            this.Setting.TabStop = false;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // PersonAddress
            // 
            this.PersonAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.PersonAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonAddress.ForeColor = System.Drawing.Color.White;
            this.PersonAddress.Location = new System.Drawing.Point(319, 401);
            this.PersonAddress.Multiline = true;
            this.PersonAddress.Name = "PersonAddress";
            this.PersonAddress.ReadOnly = true;
            this.PersonAddress.Size = new System.Drawing.Size(200, 99);
            this.PersonAddress.TabIndex = 31;
            this.PersonAddress.Text = "Address";
            this.PersonAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserPhoto
            // 
            this.UserPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPhoto.BackgroundImage = global::ParkCars.Properties.Resources.man_user__1_;
            this.UserPhoto.Location = new System.Drawing.Point(348, 59);
            this.UserPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.Size = new System.Drawing.Size(134, 128);
            this.UserPhoto.TabIndex = 24;
            this.UserPhoto.TabStop = false;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PersonProfileWindow);
            this.Name = "AdminProfile";
            this.Size = new System.Drawing.Size(875, 577);
            this.PersonProfileWindow.ResumeLayout(false);
            this.PersonProfileWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PersonProfileWindow;
        private System.Windows.Forms.TextBox PersonName;
        private System.Windows.Forms.TextBox PersonEmailAddress;
        private System.Windows.Forms.TextBox PersonUsername;
        private System.Windows.Forms.TextBox PersonID;
        private System.Windows.Forms.PictureBox Setting;
        private System.Windows.Forms.TextBox PersonAddress;
        private System.Windows.Forms.PictureBox UserPhoto;
    }
}
