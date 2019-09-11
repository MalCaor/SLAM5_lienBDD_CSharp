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
            // FCompositeurStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboStyle);
            this.Controls.Add(this.dgvCompStyle);
            this.Name = "FCompositeurStyle";
            this.Text = "FCompositeurStyle";
            this.Load += new System.EventHandler(this.FCompositeurStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscomp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompStyle;
        private System.Windows.Forms.BindingSource bsstyle;
        private System.Windows.Forms.ComboBox comboStyle;
        private System.Windows.Forms.BindingSource bscomp;
    }
}