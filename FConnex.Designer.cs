namespace SLAM5_lienBDD_CSharp
{
    partial class FConnex
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
            this.lID = new System.Windows.Forms.Label();
            this.lMDP = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.bOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(32, 71);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(53, 13);
            this.lID.TabIndex = 0;
            this.lID.Text = "Identifiant";
            // 
            // lMDP
            // 
            this.lMDP.AutoSize = true;
            this.lMDP.Location = new System.Drawing.Point(13, 109);
            this.lMDP.Name = "lMDP";
            this.lMDP.Size = new System.Drawing.Size(72, 13);
            this.lMDP.TabIndex = 1;
            this.lMDP.Text = "Mot de Passe";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(103, 68);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 2;
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(103, 106);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(100, 20);
            this.tbMDP.TabIndex = 3;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(103, 160);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 4;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // FConnex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lMDP);
            this.Controls.Add(this.lID);
            this.Name = "FConnex";
            this.Text = "FConnex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lMDP;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.Button bOK;
    }
}