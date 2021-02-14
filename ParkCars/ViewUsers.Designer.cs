namespace ParkCars
{
    partial class ViewUsers
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
            this.ViewUserTables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUserTables)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewUserTables
            // 
            this.ViewUserTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewUserTables.BackgroundColor = System.Drawing.Color.White;
            this.ViewUserTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUserTables.Location = new System.Drawing.Point(0, 0);
            this.ViewUserTables.Name = "ViewUserTables";
            this.ViewUserTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ViewUserTables.Size = new System.Drawing.Size(875, 577);
            this.ViewUserTables.TabIndex = 0;
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewUserTables);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(875, 577);
            ((System.ComponentModel.ISupportInitialize)(this.ViewUserTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewUserTables;
    }
}
