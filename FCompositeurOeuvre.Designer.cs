namespace SLAM5_lienBDD_CSharp
{
    partial class FCompositeurOeuvre
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
            this.comboStyle = new System.Windows.Forms.ComboBox();
            this.tbfinstyle = new System.Windows.Forms.TextBox();
            this.tbdebstyle = new System.Windows.Forms.TextBox();
            this.dgvCompStyle = new System.Windows.Forms.DataGridView();
            this.bsstyle = new System.Windows.Forms.BindingSource(this.components);
            this.bscomp = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscomp)).BeginInit();
            this.SuspendLayout();
            // 
            // comboStyle
            // 
            this.comboStyle.FormattingEnabled = true;
            this.comboStyle.Location = new System.Drawing.Point(12, 12);
            this.comboStyle.Name = "comboStyle";
            this.comboStyle.Size = new System.Drawing.Size(121, 21);
            this.comboStyle.TabIndex = 2;
            // 
            // tbfinstyle
            // 
            this.tbfinstyle.Location = new System.Drawing.Point(68, 39);
            this.tbfinstyle.Name = "tbfinstyle";
            this.tbfinstyle.ReadOnly = true;
            this.tbfinstyle.Size = new System.Drawing.Size(50, 20);
            this.tbfinstyle.TabIndex = 5;
            // 
            // tbdebstyle
            // 
            this.tbdebstyle.Location = new System.Drawing.Point(12, 39);
            this.tbdebstyle.Name = "tbdebstyle";
            this.tbdebstyle.ReadOnly = true;
            this.tbdebstyle.Size = new System.Drawing.Size(50, 20);
            this.tbdebstyle.TabIndex = 4;
            // 
            // dgvCompStyle
            // 
            this.dgvCompStyle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompStyle.Location = new System.Drawing.Point(13, 65);
            this.dgvCompStyle.Name = "dgvCompStyle";
            this.dgvCompStyle.Size = new System.Drawing.Size(182, 373);
            this.dgvCompStyle.TabIndex = 6;
            // 
            // bsstyle
            // 
            this.bsstyle.CurrentChanged += new System.EventHandler(this.Bsstyle_CurrentChanged);
            // 
            // FCompositeurOeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCompStyle);
            this.Controls.Add(this.tbfinstyle);
            this.Controls.Add(this.tbdebstyle);
            this.Controls.Add(this.comboStyle);
            this.Name = "FCompositeurOeuvre";
            this.Text = "FCompositeurOeuvre";
            this.Load += new System.EventHandler(this.FCompositeurOeuvre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStyle;
        private System.Windows.Forms.TextBox tbfinstyle;
        private System.Windows.Forms.TextBox tbdebstyle;
        private System.Windows.Forms.DataGridView dgvCompStyle;
        private System.Windows.Forms.BindingSource bsstyle;
        private System.Windows.Forms.BindingSource bscomp;
    }
}