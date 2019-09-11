namespace SLAM5_lienBDD_CSharp
{
    partial class FCompositeurStyle
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
            this.dgvCompStyle = new System.Windows.Forms.DataGridView();
            this.bsstyle = new System.Windows.Forms.BindingSource(this.components);
            this.comboStyle = new System.Windows.Forms.ComboBox();
            this.bscomp = new System.Windows.Forms.BindingSource(this.components);
            this.tbdebstyle = new System.Windows.Forms.TextBox();
            this.tbfinstyle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscomp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompStyle
            // 
            this.dgvCompStyle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompStyle.Location = new System.Drawing.Point(13, 71);
            this.dgvCompStyle.Name = "dgvCompStyle";
            this.dgvCompStyle.Size = new System.Drawing.Size(775, 367);
            this.dgvCompStyle.TabIndex = 0;
            // 
            // bsstyle
            // 
            this.bsstyle.CurrentChanged += new System.EventHandler(this.Bsstyle_CurrentChanged);
            // 
            // comboStyle
            // 
            this.comboStyle.FormattingEnabled = true;
            this.comboStyle.Location = new System.Drawing.Point(52, 27);
            this.comboStyle.Name = "comboStyle";
            this.comboStyle.Size = new System.Drawing.Size(121, 21);
            this.comboStyle.TabIndex = 1;
            // 
            // tbdebstyle
            // 
            this.tbdebstyle.Location = new System.Drawing.Point(247, 27);
            this.tbdebstyle.Name = "tbdebstyle";
            this.tbdebstyle.ReadOnly = true;
            this.tbdebstyle.Size = new System.Drawing.Size(100, 20);
            this.tbdebstyle.TabIndex = 2;
            // 
            // tbfinstyle
            // 
            this.tbfinstyle.Location = new System.Drawing.Point(395, 27);
            this.tbfinstyle.Name = "tbfinstyle";
            this.tbfinstyle.ReadOnly = true;
            this.tbfinstyle.Size = new System.Drawing.Size(100, 20);
            this.tbfinstyle.TabIndex = 3;
            this.tbfinstyle.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // FCompositeurStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbfinstyle);
            this.Controls.Add(this.tbdebstyle);
            this.Controls.Add(this.comboStyle);
            this.Controls.Add(this.dgvCompStyle);
            this.Name = "FCompositeurStyle";
            this.Text = "FCompositeurStyle";
            this.Load += new System.EventHandler(this.FCompositeurStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscomp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompStyle;
        private System.Windows.Forms.BindingSource bsstyle;
        private System.Windows.Forms.ComboBox comboStyle;
        private System.Windows.Forms.BindingSource bscomp;
        private System.Windows.Forms.TextBox tbdebstyle;
        private System.Windows.Forms.TextBox tbfinstyle;
    }
}