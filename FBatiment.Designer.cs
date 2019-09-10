namespace SLAM5_lienBDD_CSharp
{
    partial class FBatiment
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
            this.dgvbat = new System.Windows.Forms.DataGridView();
            this.bsbat = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsbat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbat
            // 
            this.dgvbat.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvbat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbat.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvbat.Location = new System.Drawing.Point(2, 1);
            this.dgvbat.Name = "dgvbat";
            this.dgvbat.Size = new System.Drawing.Size(796, 449);
            this.dgvbat.TabIndex = 9;
            // 
            // bsbat
            // 
            this.bsbat.CurrentChanged += new System.EventHandler(this.Bsbat_CurrentChanged);
            // 
            // FBatiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvbat);
            this.Name = "FBatiment";
            this.Text = "FBatiment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsbat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbat;
        private System.Windows.Forms.BindingSource bsbat;
    }
}