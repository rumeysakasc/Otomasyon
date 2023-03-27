namespace NküOtomasyon
{
    partial class userControl11
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
            this.gridKitap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKitap
            // 
            this.gridKitap.AllowUserToAddRows = false;
            this.gridKitap.AllowUserToDeleteRows = false;
            this.gridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKitap.Location = new System.Drawing.Point(-9, 0);
            this.gridKitap.Name = "gridKitap";
            this.gridKitap.ReadOnly = true;
            this.gridKitap.RowHeadersWidth = 51;
            this.gridKitap.RowTemplate.Height = 24;
            this.gridKitap.Size = new System.Drawing.Size(877, 698);
            this.gridKitap.TabIndex = 6;
            this.gridKitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKitap_CellContentClick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridKitap);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(859, 698);
            ((System.ComponentModel.ISupportInitialize)(this.gridKitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKitap;
    }
}
