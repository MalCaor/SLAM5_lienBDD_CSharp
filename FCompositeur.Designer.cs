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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.comboCompNat = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsnat = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnat)).BeginInit();
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
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // comboCompNat
            // 
            this.comboCompNat.FormattingEnabled = true;
            this.comboCompNat.Location = new System.Drawing.Point(141, 13);
            this.comboCompNat.Name = "comboCompNat";
            this.comboCompNat.Size = new System.Drawing.Size(121, 21);
            this.comboCompNat.TabIndex = 1;
            this.comboCompNat.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Nationalité";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // bsnat
            // 
            this.bsnat.CurrentChanged += new System.EventHandler(this.BindingSource1_CurrentChanged);
            // 
            // FCompositeurNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboCompNat);
            this.Controls.Add(this.dgvComp);
            this.Name = "FCompositeurNation";
            this.Text = "FCompositeurNation";
            this.Load += new System.EventHandler(this.FCompositeurNation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComp;
        private System.Windows.Forms.BindingSource bsComp;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox comboCompNat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bsnat;
    }
}