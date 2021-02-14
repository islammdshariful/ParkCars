namespace ParkCars
{
    partial class BookSlot
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
            this.UserIDForBookSlot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BookSlotButton = new System.Windows.Forms.Button();
            this.SlotNumber = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UserIDForBookSlot
            // 
            this.UserIDForBookSlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIDForBookSlot.Location = new System.Drawing.Point(83, 85);
            this.UserIDForBookSlot.Margin = new System.Windows.Forms.Padding(2);
            this.UserIDForBookSlot.Name = "UserIDForBookSlot";
            this.UserIDForBookSlot.Size = new System.Drawing.Size(102, 13);
            this.UserIDForBookSlot.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "BOOK SLOT";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(26, 161);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(45, 22);
            this.ResetButton.TabIndex = 42;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BookSlotButton
            // 
            this.BookSlotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BookSlotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookSlotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookSlotButton.ForeColor = System.Drawing.Color.White;
            this.BookSlotButton.Location = new System.Drawing.Point(150, 161);
            this.BookSlotButton.Margin = new System.Windows.Forms.Padding(2);
            this.BookSlotButton.Name = "BookSlotButton";
            this.BookSlotButton.Size = new System.Drawing.Size(45, 22);
            this.BookSlotButton.TabIndex = 43;
            this.BookSlotButton.Text = "Book";
            this.BookSlotButton.UseVisualStyleBackColor = false;
            this.BookSlotButton.Click += new System.EventHandler(this.BookSlotButton_Click);
            // 
            // SlotNumber
            // 
            this.SlotNumber.AutoSize = true;
            this.SlotNumber.ForeColor = System.Drawing.Color.White;
            this.SlotNumber.Location = new System.Drawing.Point(107, 47);
            this.SlotNumber.Name = "SlotNumber";
            this.SlotNumber.Size = new System.Drawing.Size(0, 13);
            this.SlotNumber.TabIndex = 46;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.Location = new System.Drawing.Point(24, 20);
            this.Clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(30, 13);
            this.Clock.TabIndex = 47;
            this.Clock.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // BookSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(230, 219);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.SlotNumber);
            this.Controls.Add(this.BookSlotButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UserIDForBookSlot);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookSlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSlot";
            this.Load += new System.EventHandler(this.BookSlot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserIDForBookSlot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button BookSlotButton;
        private System.Windows.Forms.Label SlotNumber;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer1;
    }
}