namespace SLAM5_lienBDD_CSharp
{
    partial class FTypeOeuvre
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
            this.dgvto = new System.Windows.Forms.DataGridView();
            this.bsto = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvto
            // 
            this.dgvto.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvto.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvto.Location = new System.Drawing.Point(2, 1);
            this.dgvto.Name = "dgvto";
            this.dgvto.Size = new System.Drawing.Size(796, 449);
            this.dgvto.TabIndex = 10;
            // 
            // FTypeOeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvto);
            this.Name = "FTypeOeuvre";
            this.Text = "FTypeOeuvre";
            ((System.ComponentModel.ISupportInitialize)(this.dgvto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvto;
        private System.Windows.Forms.BindingSource bsto;
    }
}