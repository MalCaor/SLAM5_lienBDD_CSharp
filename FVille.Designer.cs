namespace SLAM5_lienBDD_CSharp
{
    partial class FVille
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
            this.dgvville = new System.Windows.Forms.DataGridView();
            this.bssalle = new System.Windows.Forms.BindingSource(this.components);
            this.bsbat = new System.Windows.Forms.BindingSource(this.components);
            this.bstoeuvre = new System.Windows.Forms.BindingSource(this.components);
            this.bsVille = new System.Windows.Forms.BindingSource(this.components);
            this.sALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bATIMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPEOEUVREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvville)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsbat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstoeuvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bATIMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEOEUVREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvville
            // 
            this.dgvville.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvville.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvville.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvville.Location = new System.Drawing.Point(12, 12);
            this.dgvville.Name = "dgvville";
            this.dgvville.Size = new System.Drawing.Size(796, 449);
            this.dgvville.TabIndex = 8;
            // 
            // bsVille
            // 
            this.bsVille.DataSource = typeof(SLAM5_lienBDD_CSharp.VILLE);
            // 
            // sALLEBindingSource
            // 
            this.sALLEBindingSource.DataSource = typeof(SLAM5_lienBDD_CSharp.SALLE);
            // 
            // bATIMENTBindingSource
            // 
            this.bATIMENTBindingSource.DataSource = typeof(SLAM5_lienBDD_CSharp.BATIMENT);
            // 
            // tYPEOEUVREBindingSource
            // 
            this.tYPEOEUVREBindingSource.DataSource = typeof(SLAM5_lienBDD_CSharp.TYPEOEUVRE);
            // 
            // FVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 473);
            this.Controls.Add(this.dgvville);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FVille";
            this.Text = "FVille";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgvville)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsbat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstoeuvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bATIMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPEOEUVREBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVille;
        private System.Windows.Forms.BindingSource sALLEBindingSource;
        private System.Windows.Forms.BindingSource bATIMENTBindingSource;
        private System.Windows.Forms.BindingSource tYPEOEUVREBindingSource;
        private System.Windows.Forms.BindingSource bssalle;
        private System.Windows.Forms.BindingSource bsbat;
        private System.Windows.Forms.BindingSource bstoeuvre;
        private System.Windows.Forms.DataGridView dgvville;
    }
}