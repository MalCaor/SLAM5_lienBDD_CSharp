namespace SLAM5_lienBDD_CSharp
{
    partial class FModifComp
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.cbstyle = new System.Windows.Forms.ComboBox();
            this.lStyle = new System.Windows.Forms.Label();
            this.cbnat = new System.Windows.Forms.ComboBox();
            this.lNat = new System.Windows.Forms.Label();
            this.tbmort = new System.Windows.Forms.TextBox();
            this.lmort = new System.Windows.Forms.Label();
            this.tbnais = new System.Windows.Forms.TextBox();
            this.lNais = new System.Windows.Forms.Label();
            this.rtbRemarque = new System.Windows.Forms.RichTextBox();
            this.lrem = new System.Windows.Forms.Label();
            this.tbprenom = new System.Windows.Forms.TextBox();
            this.lpre = new System.Windows.Forms.Label();
            this.tbnom = new System.Windows.Forms.TextBox();
            this.lnom = new System.Windows.Forms.Label();
            this.bsstyle = new System.Windows.Forms.BindingSource(this.components);
            this.bsnat = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnat)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(91, 272);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 31;
            this.bCancel.Text = "CANCEL";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(10, 272);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 30;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // cbstyle
            // 
            this.cbstyle.FormattingEnabled = true;
            this.cbstyle.Location = new System.Drawing.Point(70, 233);
            this.cbstyle.Name = "cbstyle";
            this.cbstyle.Size = new System.Drawing.Size(121, 21);
            this.cbstyle.TabIndex = 29;
            // 
            // lStyle
            // 
            this.lStyle.AutoSize = true;
            this.lStyle.Location = new System.Drawing.Point(11, 236);
            this.lStyle.Name = "lStyle";
            this.lStyle.Size = new System.Drawing.Size(30, 13);
            this.lStyle.TabIndex = 28;
            this.lStyle.Text = "Style";
            // 
            // cbnat
            // 
            this.cbnat.FormattingEnabled = true;
            this.cbnat.Location = new System.Drawing.Point(70, 206);
            this.cbnat.Name = "cbnat";
            this.cbnat.Size = new System.Drawing.Size(121, 21);
            this.cbnat.TabIndex = 27;
            // 
            // lNat
            // 
            this.lNat.AutoSize = true;
            this.lNat.Location = new System.Drawing.Point(11, 209);
            this.lNat.Name = "lNat";
            this.lNat.Size = new System.Drawing.Size(57, 13);
            this.lNat.TabIndex = 26;
            this.lNat.Text = "Nationalité";
            // 
            // tbmort
            // 
            this.tbmort.Location = new System.Drawing.Point(226, 170);
            this.tbmort.Name = "tbmort";
            this.tbmort.Size = new System.Drawing.Size(100, 20);
            this.tbmort.TabIndex = 25;
            // 
            // lmort
            // 
            this.lmort.AutoSize = true;
            this.lmort.Location = new System.Drawing.Point(177, 173);
            this.lmort.Name = "lmort";
            this.lmort.Size = new System.Drawing.Size(43, 13);
            this.lmort.TabIndex = 24;
            this.lmort.Text = "an Mort";
            // 
            // tbnais
            // 
            this.tbnais.Location = new System.Drawing.Point(68, 170);
            this.tbnais.Name = "tbnais";
            this.tbnais.Size = new System.Drawing.Size(100, 20);
            this.tbnais.TabIndex = 23;
            // 
            // lNais
            // 
            this.lNais.AutoSize = true;
            this.lNais.Location = new System.Drawing.Point(11, 173);
            this.lNais.Name = "lNais";
            this.lNais.Size = new System.Drawing.Size(43, 13);
            this.lNais.TabIndex = 22;
            this.lNais.Text = "an Nais";
            // 
            // rtbRemarque
            // 
            this.rtbRemarque.Location = new System.Drawing.Point(68, 68);
            this.rtbRemarque.Name = "rtbRemarque";
            this.rtbRemarque.Size = new System.Drawing.Size(423, 96);
            this.rtbRemarque.TabIndex = 21;
            this.rtbRemarque.Text = "";
            // 
            // lrem
            // 
            this.lrem.AutoSize = true;
            this.lrem.Location = new System.Drawing.Point(11, 68);
            this.lrem.Name = "lrem";
            this.lrem.Size = new System.Drawing.Size(51, 13);
            this.lrem.TabIndex = 20;
            this.lrem.Text = "remarque";
            // 
            // tbprenom
            // 
            this.tbprenom.Location = new System.Drawing.Point(68, 39);
            this.tbprenom.Name = "tbprenom";
            this.tbprenom.Size = new System.Drawing.Size(100, 20);
            this.tbprenom.TabIndex = 19;
            // 
            // lpre
            // 
            this.lpre.AutoSize = true;
            this.lpre.Location = new System.Drawing.Point(11, 42);
            this.lpre.Name = "lpre";
            this.lpre.Size = new System.Drawing.Size(42, 13);
            this.lpre.TabIndex = 18;
            this.lpre.Text = "prenom";
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(68, 13);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(100, 20);
            this.tbnom.TabIndex = 17;
            this.tbnom.TextChanged += new System.EventHandler(this.Tbnom_TextChanged);
            // 
            // lnom
            // 
            this.lnom.AutoSize = true;
            this.lnom.Location = new System.Drawing.Point(11, 16);
            this.lnom.Name = "lnom";
            this.lnom.Size = new System.Drawing.Size(27, 13);
            this.lnom.TabIndex = 16;
            this.lnom.Text = "nom";
            // 
            // FModifComp
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cbstyle);
            this.Controls.Add(this.lStyle);
            this.Controls.Add(this.cbnat);
            this.Controls.Add(this.lNat);
            this.Controls.Add(this.tbmort);
            this.Controls.Add(this.lmort);
            this.Controls.Add(this.tbnais);
            this.Controls.Add(this.lNais);
            this.Controls.Add(this.rtbRemarque);
            this.Controls.Add(this.lrem);
            this.Controls.Add(this.tbprenom);
            this.Controls.Add(this.lpre);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.lnom);
            this.Name = "FModifComp";
            this.Text = "FModifComp";
            this.Load += new System.EventHandler(this.FAjoutComp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsnat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsstyle;
        private System.Windows.Forms.BindingSource bsnat;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.ComboBox cbstyle;
        private System.Windows.Forms.Label lStyle;
        private System.Windows.Forms.ComboBox cbnat;
        private System.Windows.Forms.Label lNat;
        private System.Windows.Forms.TextBox tbmort;
        private System.Windows.Forms.Label lmort;
        private System.Windows.Forms.TextBox tbnais;
        private System.Windows.Forms.Label lNais;
        private System.Windows.Forms.RichTextBox rtbRemarque;
        private System.Windows.Forms.Label lrem;
        private System.Windows.Forms.TextBox tbprenom;
        private System.Windows.Forms.Label lpre;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.Label lnom;
    }
}