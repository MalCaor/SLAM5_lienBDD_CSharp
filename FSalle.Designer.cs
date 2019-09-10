namespace SLAM5_lienBDD_CSharp
{
    partial class FSalle
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
            this.bssalle = new System.Windows.Forms.BindingSource(this.components);
            this.dgvsalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bssalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsalle
            // 
            this.dgvsalle.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvsalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalle.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvsalle.Location = new System.Drawing.Point(2, 1);
            this.dgvsalle.Name = "dgvsalle";
            this.dgvsalle.Size = new System.Drawing.Size(796, 449);
            this.dgvsalle.TabIndex = 9;
            // 
            // FSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvsalle);
            this.Name = "FSalle";
            this.Text = "FSalle";
            ((System.ComponentModel.ISupportInitialize)(this.bssalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bssalle;
        private System.Windows.Forms.DataGridView dgvsalle;
    }
}