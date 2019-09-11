namespace SLAM5_lienBDD_CSharp
{
    partial class FCompositeurNation
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
            this.dgvComp = new System.Windows.Forms.DataGridView();
            this.bsComp = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsComp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComp
            // 
            this.dgvComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComp.Location = new System.Drawing.Point(12, 56);
            this.dgvComp.Name = "dgvComp";
            this.dgvComp.Size = new System.Drawing.Size(776, 382);
            this.dgvComp.TabIndex = 0;
            // 
            // FCompositeurNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvComp);
            this.Name = "FCompositeurNation";
            this.Text = "FCompositeurNation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComp;
        private System.Windows.Forms.BindingSource bsComp;
    }
}