namespace ParkCars
{
    partial class SystemView
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMemberMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.VehicleRecordsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Drawer = new System.Windows.Forms.Panel();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ScannerDevice = new System.Windows.Forms.ComboBox();
            this.UserIDFromScan = new System.Windows.Forms.TextBox();
            this.ScannerCamera = new System.Windows.Forms.PictureBox();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.VehicleListButton = new System.Windows.Forms.Button();
            this.ParkingSlotButton = new System.Windows.Forms.Button();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Window = new System.Windows.Forms.Panel();
            this.ParkingWindow = new System.Windows.Forms.Panel();
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.Drawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerCamera)).BeginInit();
            this.Window.SuspendLayout();
            this.ParkingWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMemberMenu,
            this.VehicleRecordsMenu,
            this.ExitMenu});
            this.FileMenu.ForeColor = System.Drawing.Color.White;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // ViewMemberMenu
            // 
            this.ViewMemberMenu.Image = global::ParkCars.Properties.Resources.viewmemebrzzss;
            this.ViewMemberMenu.Name = "ViewMemberMenu";
            this.ViewMemberMenu.Size = new System.Drawing.Size(156, 22);
            this.ViewMemberMenu.Text = "View Members";
            this.ViewMemberMenu.Click += new System.EventHandler(this.ViewMemberMenu_Click);
            // 
            // VehicleRecordsMenu
            // 
            this.VehicleRecordsMenu.Image = global::ParkCars.Properties.Resources.car1;
            this.VehicleRecordsMenu.Name = "VehicleRecordsMenu";
            this.VehicleRecordsMenu.Size = new System.Drawing.Size(156, 22);
            this.VehicleRecordsMenu.Text = "Vehicle Records";
            this.VehicleRecordsMenu.Click += new System.EventHandler(this.VehicleRecordsMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Image = global::ParkCars.Properties.Resources.icons8_cancel_32;
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(156, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu});
            this.HelpMenu.ForeColor = System.Drawing.Color.White;
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(107, 22);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // Drawer
            // 
            this.Drawer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.Drawer.Controls.Add(this.ProfileButton);
            this.Drawer.Controls.Add(this.Clock);
            this.Drawer.Controls.Add(this.HomeButton);
            this.Drawer.Controls.Add(this.ScannerDevice);
            this.Drawer.Controls.Add(this.UserIDFromScan);
            this.Drawer.Controls.Add(this.ScannerCamera);
            this.Drawer.Controls.Add(this.SignOutButton);
            this.Drawer.Controls.Add(this.VehicleListButton);
            this.Drawer.Controls.Add(this.ParkingSlotButton);
            this.Drawer.Controls.Add(this.AddMemberButton);
            this.Drawer.Location = new System.Drawing.Point(880, 24);
            this.Drawer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Drawer.Name = "Drawer";
            this.Drawer.Size = new System.Drawing.Size(165, 577);
            this.Drawer.TabIndex = 1;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.ProfileButton.Image = global::ParkCars.Properties.Resources.username2;
            this.ProfileButton.Location = new System.Drawing.Point(139, 200);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(23, 23);
            this.ProfileButton.TabIndex = 10;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // Clock
            // 
            this.Clock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Clock.AutoSize = true;
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.Location = new System.Drawing.Point(2, 231);
            this.Clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(30, 13);
            this.Clock.TabIndex = 9;
            this.Clock.Text = "Time";
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.HomeButton.Image = global::ParkCars.Properties.Resources.car_history;
            this.HomeButton.Location = new System.Drawing.Point(96, 191);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(38, 35);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ScannerDevice
            // 
            this.ScannerDevice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ScannerDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.ScannerDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.ScannerDevice.FormattingEnabled = true;
            this.ScannerDevice.Location = new System.Drawing.Point(2, 188);
            this.ScannerDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScannerDevice.Name = "ScannerDevice";
            this.ScannerDevice.Size = new System.Drawing.Size(20, 21);
            this.ScannerDevice.TabIndex = 7;
            this.ScannerDevice.SelectedIndexChanged += new System.EventHandler(this.ScannerDevice_SelectedIndexChanged);
            // 
            // UserIDFromScan
            // 
            this.UserIDFromScan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UserIDFromScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.UserIDFromScan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIDFromScan.ForeColor = System.Drawing.SystemColors.Window;
            this.UserIDFromScan.Location = new System.Drawing.Point(26, 190);
            this.UserIDFromScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserIDFromScan.Name = "UserIDFromScan";
            this.UserIDFromScan.ReadOnly = true;
            this.UserIDFromScan.Size = new System.Drawing.Size(55, 13);
            this.UserIDFromScan.TabIndex = 6;
            // 
            // ScannerCamera
            // 
            this.ScannerCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ScannerCamera.Location = new System.Drawing.Point(-1, 0);
            this.ScannerCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScannerCamera.Name = "ScannerCamera";
            this.ScannerCamera.Size = new System.Drawing.Size(166, 184);
            this.ScannerCamera.TabIndex = 4;
            this.ScannerCamera.TabStop = false;
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignOutButton.BackColor = System.Drawing.Color.White;
            this.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.SignOutButton.Image = global::ParkCars.Properties.Resources.logout;
            this.SignOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOutButton.Location = new System.Drawing.Point(0, 500);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(164, 66);
            this.SignOutButton.TabIndex = 3;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // VehicleListButton
            // 
            this.VehicleListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleListButton.BackColor = System.Drawing.Color.White;
            this.VehicleListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehicleListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.VehicleListButton.Image = global::ParkCars.Properties.Resources.if_Parking_2_753118__1_1;
            this.VehicleListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VehicleListButton.Location = new System.Drawing.Point(1, 421);
            this.VehicleListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VehicleListButton.Name = "VehicleListButton";
            this.VehicleListButton.Size = new System.Drawing.Size(164, 66);
            this.VehicleListButton.TabIndex = 2;
            this.VehicleListButton.Text = "Vehicle List";
            this.VehicleListButton.UseVisualStyleBackColor = false;
            this.VehicleListButton.Click += new System.EventHandler(this.VehicleListButton_Click);
            // 
            // ParkingSlotButton
            // 
            this.ParkingSlotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ParkingSlotButton.BackColor = System.Drawing.Color.White;
            this.ParkingSlotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParkingSlotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkingSlotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.ParkingSlotButton.Image = global::ParkCars.Properties.Resources.car1;
            this.ParkingSlotButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParkingSlotButton.Location = new System.Drawing.Point(0, 337);
            this.ParkingSlotButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParkingSlotButton.Name = "ParkingSlotButton";
            this.ParkingSlotButton.Size = new System.Drawing.Size(164, 66);
            this.ParkingSlotButton.TabIndex = 1;
            this.ParkingSlotButton.Text = "Parking Slot";
            this.ParkingSlotButton.UseVisualStyleBackColor = false;
            this.ParkingSlotButton.Click += new System.EventHandler(this.ParkingSlotButton_Click);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMemberButton.BackColor = System.Drawing.Color.White;
            this.AddMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.AddMemberButton.Image = global::ParkCars.Properties.Resources.if_Sed_02_2232585;
            this.AddMemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMemberButton.Location = new System.Drawing.Point(-1, 256);
            this.AddMemberButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(165, 66);
            this.AddMemberButton.TabIndex = 0;
            this.AddMemberButton.Text = "Add User";
            this.AddMemberButton.UseVisualStyleBackColor = false;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Window
            // 
            this.Window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Window.BackColor = System.Drawing.Color.Black;
            this.Window.Controls.Add(this.ParkingWindow);
            this.Window.Location = new System.Drawing.Point(0, 24);
            this.Window.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Window.Name = "Window";
            this.Window.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Window.Size = new System.Drawing.Size(875, 577);
            this.Window.TabIndex = 2;
            // 
            // ParkingWindow
            // 
            this.ParkingWindow.AutoSize = true;
            this.ParkingWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.ParkingWindow.Controls.Add(this.HomeIcon);
            this.ParkingWindow.Controls.Add(this.label1);
            this.ParkingWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParkingWindow.Location = new System.Drawing.Point(0, 0);
            this.ParkingWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParkingWindow.Name = "ParkingWindow";
            this.ParkingWindow.Size = new System.Drawing.Size(875, 577);
            this.ParkingWindow.TabIndex = 0;
            // 
            // HomeIcon
            // 
            this.HomeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeIcon.BackgroundImage = global::ParkCars.Properties.Resources.if_Parking_751082;
            this.HomeIcon.Location = new System.Drawing.Point(106, 231);
            this.HomeIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(256, 256);
            this.HomeIcon.TabIndex = 3;
            this.HomeIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(104, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to ParkCars";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // SystemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1046, 601);
            this.Controls.Add(this.Window);
            this.Controls.Add(this.Drawer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1062, 638);
            this.Name = "SystemView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemView";
            this.Load += new System.EventHandler(this.SystemView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Drawer.ResumeLayout(false);
            this.Drawer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerCamera)).EndInit();
            this.Window.ResumeLayout(false);
            this.Window.PerformLayout();
            this.ParkingWindow.ResumeLayout(false);
            this.ParkingWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel Drawer;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewMemberMenu;
        private System.Windows.Forms.ToolStripMenuItem VehicleRecordsMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.Button ParkingSlotButton;
        private System.Windows.Forms.Button VehicleListButton;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.PictureBox ScannerCamera;
        private System.Windows.Forms.ComboBox ScannerDevice;
        private System.Windows.Forms.TextBox UserIDFromScan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Window;
        private System.Windows.Forms.Panel ParkingWindow;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox HomeIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button ProfileButton;
    }
}