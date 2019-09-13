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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOeuvre = new System.Windows.Forms.DataGridView();
            this.lOeuvreComp = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.tbDece = new System.Windows.Forms.TextBox();
            this.lDece = new System.Windows.Forms.Label();
            this.tbNais = new System.Windows.Forms.TextBox();
            this.lNais = new System.Windows.Forms.Label();
            this.tbStyle = new System.Windows.Forms.TextBox();
            this.lStyle = new System.Windows.Forms.Label();
            this.tbNati = new System.Windows.Forms.TextBox();
            this.lNati = new System.Windows.Forms.Label();
            this.tbVouAveSelec = new System.Windows.Forms.TextBox();
            this.lVouAveSelec = new System.Windows.Forms.Label();
            this.bsoeuvre = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsstyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bscomp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoeuvre)).BeginInit();
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
            this.dgvCompStyle.Size = new System.Drawing.Size(339, 373);
            this.dgvCompStyle.TabIndex = 6;
            // 
            // bsstyle
            // 
            this.bsstyle.CurrentChanged += new System.EventHandler(this.Bsstyle_CurrentChanged);
            // 
            // bscomp
            // 
            this.bscomp.CurrentChanged += new System.EventHandler(this.Bscomp_CurrentChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.dgvOeuvre);
            this.panel1.Controls.Add(this.lOeuvreComp);
            this.panel1.Controls.Add(this.rtbDesc);
            this.panel1.Controls.Add(this.tbDece);
            this.panel1.Controls.Add(this.lDece);
            this.panel1.Controls.Add(this.tbNais);
            this.panel1.Controls.Add(this.lNais);
            this.panel1.Controls.Add(this.tbStyle);
            this.panel1.Controls.Add(this.lStyle);
            this.panel1.Controls.Add(this.tbNati);
            this.panel1.Controls.Add(this.lNati);
            this.panel1.Controls.Add(this.tbVouAveSelec);
            this.panel1.Controls.Add(this.lVouAveSelec);
            this.panel1.Location = new System.Drawing.Point(358, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 426);
            this.panel1.TabIndex = 7;
            // 
            // dgvOeuvre
            // 
            this.dgvOeuvre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOeuvre.Location = new System.Drawing.Point(7, 213);
            this.dgvOeuvre.Name = "dgvOeuvre";
            this.dgvOeuvre.Size = new System.Drawing.Size(413, 210);
            this.dgvOeuvre.TabIndex = 12;
            // 
            // lOeuvreComp
            // 
            this.lOeuvreComp.AutoSize = true;
            this.lOeuvreComp.Location = new System.Drawing.Point(4, 197);
            this.lOeuvreComp.Name = "lOeuvreComp";
            this.lOeuvreComp.Size = new System.Drawing.Size(155, 13);
            this.lOeuvreComp.TabIndex = 11;
            this.lOeuvreComp.Text = "Les oeuvres de ce compositeur";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(7, 87);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(413, 96);
            this.rtbDesc.TabIndex = 10;
            this.rtbDesc.Text = "";
            // 
            // tbDece
            // 
            this.tbDece.Location = new System.Drawing.Point(238, 61);
            this.tbDece.Name = "tbDece";
            this.tbDece.Size = new System.Drawing.Size(45, 20);
            this.tbDece.TabIndex = 9;
            // 
            // lDece
            // 
            this.lDece.AutoSize = true;
            this.lDece.Location = new System.Drawing.Point(175, 64);
            this.lDece.Name = "lDece";
            this.lDece.Size = new System.Drawing.Size(38, 13);
            this.lDece.TabIndex = 8;
            this.lDece.Text = "Décès";
            // 
            // tbNais
            // 
            this.tbNais.Location = new System.Drawing.Point(124, 61);
            this.tbNais.Name = "tbNais";
            this.tbNais.Size = new System.Drawing.Size(45, 20);
            this.tbNais.TabIndex = 7;
            // 
            // lNais
            // 
            this.lNais.AutoSize = true;
            this.lNais.Location = new System.Drawing.Point(4, 64);
            this.lNais.Name = "lNais";
            this.lNais.Size = new System.Drawing.Size(57, 13);
            this.lNais.TabIndex = 6;
            this.lNais.Text = "Naissance";
            // 
            // tbStyle
            // 
            this.tbStyle.Location = new System.Drawing.Point(320, 31);
            this.tbStyle.Name = "tbStyle";
            this.tbStyle.Size = new System.Drawing.Size(100, 20);
            this.tbStyle.TabIndex = 5;
            // 
            // lStyle
            // 
            this.lStyle.AutoSize = true;
            this.lStyle.Location = new System.Drawing.Point(247, 34);
            this.lStyle.Name = "lStyle";
            this.lStyle.Size = new System.Drawing.Size(30, 13);
            this.lStyle.TabIndex = 4;
            this.lStyle.Text = "Style";
            // 
            // tbNati
            // 
            this.tbNati.Location = new System.Drawing.Point(124, 31);
            this.tbNati.Name = "tbNati";
            this.tbNati.Size = new System.Drawing.Size(100, 20);
            this.tbNati.TabIndex = 3;
            // 
            // lNati
            // 
            this.lNati.AutoSize = true;
            this.lNati.Location = new System.Drawing.Point(4, 34);
            this.lNati.Name = "lNati";
            this.lNati.Size = new System.Drawing.Size(57, 13);
            this.lNati.TabIndex = 2;
            this.lNati.Text = "Nationalité";
            // 
            // tbVouAveSelec
            // 
            this.tbVouAveSelec.Location = new System.Drawing.Point(124, 4);
            this.tbVouAveSelec.Name = "tbVouAveSelec";
            this.tbVouAveSelec.Size = new System.Drawing.Size(296, 20);
            this.tbVouAveSelec.TabIndex = 1;
            // 
            // lVouAveSelec
            // 
            this.lVouAveSelec.AutoSize = true;
            this.lVouAveSelec.Location = new System.Drawing.Point(4, 7);
            this.lVouAveSelec.Name = "lVouAveSelec";
            this.lVouAveSelec.Size = new System.Drawing.Size(114, 13);
            this.lVouAveSelec.TabIndex = 0;
            this.lVouAveSelec.Text = "Vous avez séléctionné";
            this.lVouAveSelec.Click += new System.EventHandler(this.Label1_Click);
            // 
            // FCompositeurOeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoeuvre)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lVouAveSelec;
        private System.Windows.Forms.DataGridView dgvOeuvre;
        private System.Windows.Forms.Label lOeuvreComp;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TextBox tbDece;
        private System.Windows.Forms.Label lDece;
        private System.Windows.Forms.TextBox tbNais;
        private System.Windows.Forms.Label lNais;
        private System.Windows.Forms.TextBox tbStyle;
        private System.Windows.Forms.Label lStyle;
        private System.Windows.Forms.TextBox tbNati;
        private System.Windows.Forms.Label lNati;
        private System.Windows.Forms.TextBox tbVouAveSelec;
        private System.Windows.Forms.BindingSource bsoeuvre;
    }
}