namespace SLAM5_lienBDD_CSharp
{
    partial class FCompte
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnciMDP = new System.Windows.Forms.TextBox();
            this.lAnciMDP = new System.Windows.Forms.Label();
            this.lNouvMDP = new System.Windows.Forms.Label();
            this.tbNouvMDP = new System.Windows.Forms.TextBox();
            this.bOK = new System.Windows.Forms.Button();
            this.lConfMDP = new System.Windows.Forms.Label();
            this.tbConfMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compte";
            // 
            // tbAnciMDP
            // 
            this.tbAnciMDP.Location = new System.Drawing.Point(16, 57);
            this.tbAnciMDP.Name = "tbAnciMDP";
            this.tbAnciMDP.Size = new System.Drawing.Size(100, 20);
            this.tbAnciMDP.TabIndex = 1;
            // 
            // lAnciMDP
            // 
            this.lAnciMDP.AutoSize = true;
            this.lAnciMDP.Location = new System.Drawing.Point(13, 41);
            this.lAnciMDP.Name = "lAnciMDP";
            this.lAnciMDP.Size = new System.Drawing.Size(62, 13);
            this.lAnciMDP.TabIndex = 2;
            this.lAnciMDP.Text = "ancien mdp";
            // 
            // lNouvMDP
            // 
            this.lNouvMDP.AutoSize = true;
            this.lNouvMDP.Location = new System.Drawing.Point(13, 93);
            this.lNouvMDP.Name = "lNouvMDP";
            this.lNouvMDP.Size = new System.Drawing.Size(72, 13);
            this.lNouvMDP.TabIndex = 4;
            this.lNouvMDP.Text = "nouveau mdp";
            // 
            // tbNouvMDP
            // 
            this.tbNouvMDP.Location = new System.Drawing.Point(16, 109);
            this.tbNouvMDP.Name = "tbNouvMDP";
            this.tbNouvMDP.Size = new System.Drawing.Size(100, 20);
            this.tbNouvMDP.TabIndex = 3;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(16, 185);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 5;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // lConfMDP
            // 
            this.lConfMDP.AutoSize = true;
            this.lConfMDP.Location = new System.Drawing.Point(13, 143);
            this.lConfMDP.Name = "lConfMDP";
            this.lConfMDP.Size = new System.Drawing.Size(73, 13);
            this.lConfMDP.TabIndex = 7;
            this.lConfMDP.Text = "confirmer mdp";
            // 
            // tbConfMDP
            // 
            this.tbConfMDP.Location = new System.Drawing.Point(16, 159);
            this.tbConfMDP.Name = "tbConfMDP";
            this.tbConfMDP.Size = new System.Drawing.Size(100, 20);
            this.tbConfMDP.TabIndex = 6;
            // 
            // FCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lConfMDP);
            this.Controls.Add(this.tbConfMDP);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lNouvMDP);
            this.Controls.Add(this.tbNouvMDP);
            this.Controls.Add(this.lAnciMDP);
            this.Controls.Add(this.tbAnciMDP);
            this.Controls.Add(this.label1);
            this.Name = "FCompte";
            this.Text = "FCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAnciMDP;
        private System.Windows.Forms.Label lAnciMDP;
        private System.Windows.Forms.Label lNouvMDP;
        private System.Windows.Forms.TextBox tbNouvMDP;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lConfMDP;
        private System.Windows.Forms.TextBox tbConfMDP;
    }
}