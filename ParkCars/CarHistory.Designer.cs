namespace ParkCars
{
    partial class CarHistory
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
            this.CarlistTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CarlistTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CarlistTable
            // 
            this.CarlistTable.BackgroundColor = System.Drawing.Color.White;
            this.CarlistTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CarlistTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarlistTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarlistTable.GridColor = System.Drawing.Color.White;
            this.CarlistTable.Location = new System.Drawing.Point(0, 0);
            this.CarlistTable.Margin = new System.Windows.Forms.Padding(2);
            this.CarlistTable.Name = "CarlistTable";
            this.CarlistTable.ReadOnly = true;
            this.CarlistTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarlistTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.CarlistTable.RowTemplate.Height = 24;
            this.CarlistTable.Size = new System.Drawing.Size(875, 577);
            this.CarlistTable.TabIndex = 0;
            // 
            // CarHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.CarlistTable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarHistory";
            this.Size = new System.Drawing.Size(875, 577);
            ((System.ComponentModel.ISupportInitialize)(this.CarlistTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CarlistTable;
    }
}
