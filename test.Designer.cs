namespace SLAM5_lienBDD_CSharp
{
    partial class test
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
            System.Windows.Forms.Label anMortLabel;
            System.Windows.Forms.Label anNaisLabel;
            System.Windows.Forms.Label idCompositeurLabel;
            System.Windows.Forms.Label idNationLabel;
            System.Windows.Forms.Label idStyleLabel;
            System.Windows.Forms.Label nomCompositeurLabel;
            System.Windows.Forms.Label prenomCompositeurLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label idNationLabel1;
            System.Windows.Forms.Label libNationLabel;
            System.Windows.Forms.Label dateDebutLabel;
            System.Windows.Forms.Label dateFinLabel;
            System.Windows.Forms.Label idStyleLabel1;
            System.Windows.Forms.Label libStyleLabel;
            this.cOMPOSITEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anMortTextBox = new System.Windows.Forms.TextBox();
            this.anNaisTextBox = new System.Windows.Forms.TextBox();
            this.idCompositeurTextBox = new System.Windows.Forms.TextBox();
            this.idNationTextBox = new System.Windows.Forms.TextBox();
            this.idStyleTextBox = new System.Windows.Forms.TextBox();
            this.nomCompositeurTextBox = new System.Windows.Forms.TextBox();
            this.prenomCompositeurTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.idNationTextBox1 = new System.Windows.Forms.TextBox();
            this.libNationTextBox = new System.Windows.Forms.TextBox();
            this.dateDebutTextBox = new System.Windows.Forms.TextBox();
            this.dateFinTextBox = new System.Windows.Forms.TextBox();
            this.idStyleTextBox1 = new System.Windows.Forms.TextBox();
            this.libStyleTextBox = new System.Windows.Forms.TextBox();
            anMortLabel = new System.Windows.Forms.Label();
            anNaisLabel = new System.Windows.Forms.Label();
            idCompositeurLabel = new System.Windows.Forms.Label();
            idNationLabel = new System.Windows.Forms.Label();
            idStyleLabel = new System.Windows.Forms.Label();
            nomCompositeurLabel = new System.Windows.Forms.Label();
            prenomCompositeurLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            idNationLabel1 = new System.Windows.Forms.Label();
            libNationLabel = new System.Windows.Forms.Label();
            dateDebutLabel = new System.Windows.Forms.Label();
            dateFinLabel = new System.Windows.Forms.Label();
            idStyleLabel1 = new System.Windows.Forms.Label();
            libStyleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSITEURBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOMPOSITEURBindingSource
            // 
            this.cOMPOSITEURBindingSource.DataSource = typeof(SLAM5_lienBDD_CSharp.COMPOSITEUR);
            // 
            // anMortLabel
            // 
            anMortLabel.AutoSize = true;
            anMortLabel.Location = new System.Drawing.Point(246, 50);
            anMortLabel.Name = "anMortLabel";
            anMortLabel.Size = new System.Drawing.Size(46, 13);
            anMortLabel.TabIndex = 0;
            anMortLabel.Text = "an Mort:";
            // 
            // anMortTextBox
            // 
            this.anMortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "anMort", true));
            this.anMortTextBox.Location = new System.Drawing.Point(358, 47);
            this.anMortTextBox.Name = "anMortTextBox";
            this.anMortTextBox.Size = new System.Drawing.Size(100, 20);
            this.anMortTextBox.TabIndex = 1;
            // 
            // anNaisLabel
            // 
            anNaisLabel.AutoSize = true;
            anNaisLabel.Location = new System.Drawing.Point(246, 76);
            anNaisLabel.Name = "anNaisLabel";
            anNaisLabel.Size = new System.Drawing.Size(46, 13);
            anNaisLabel.TabIndex = 2;
            anNaisLabel.Text = "an Nais:";
            // 
            // anNaisTextBox
            // 
            this.anNaisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "anNais", true));
            this.anNaisTextBox.Location = new System.Drawing.Point(358, 73);
            this.anNaisTextBox.Name = "anNaisTextBox";
            this.anNaisTextBox.Size = new System.Drawing.Size(100, 20);
            this.anNaisTextBox.TabIndex = 3;
            // 
            // idCompositeurLabel
            // 
            idCompositeurLabel.AutoSize = true;
            idCompositeurLabel.Location = new System.Drawing.Point(246, 102);
            idCompositeurLabel.Name = "idCompositeurLabel";
            idCompositeurLabel.Size = new System.Drawing.Size(79, 13);
            idCompositeurLabel.TabIndex = 4;
            idCompositeurLabel.Text = "id Compositeur:";
            // 
            // idCompositeurTextBox
            // 
            this.idCompositeurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "idCompositeur", true));
            this.idCompositeurTextBox.Location = new System.Drawing.Point(358, 99);
            this.idCompositeurTextBox.Name = "idCompositeurTextBox";
            this.idCompositeurTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCompositeurTextBox.TabIndex = 5;
            // 
            // idNationLabel
            // 
            idNationLabel.AutoSize = true;
            idNationLabel.Location = new System.Drawing.Point(246, 128);
            idNationLabel.Name = "idNationLabel";
            idNationLabel.Size = new System.Drawing.Size(52, 13);
            idNationLabel.TabIndex = 6;
            idNationLabel.Text = "id Nation:";
            // 
            // idNationTextBox
            // 
            this.idNationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "idNation", true));
            this.idNationTextBox.Location = new System.Drawing.Point(358, 125);
            this.idNationTextBox.Name = "idNationTextBox";
            this.idNationTextBox.Size = new System.Drawing.Size(100, 20);
            this.idNationTextBox.TabIndex = 7;
            // 
            // idStyleLabel
            // 
            idStyleLabel.AutoSize = true;
            idStyleLabel.Location = new System.Drawing.Point(246, 154);
            idStyleLabel.Name = "idStyleLabel";
            idStyleLabel.Size = new System.Drawing.Size(44, 13);
            idStyleLabel.TabIndex = 8;
            idStyleLabel.Text = "id Style:";
            // 
            // idStyleTextBox
            // 
            this.idStyleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "idStyle", true));
            this.idStyleTextBox.Location = new System.Drawing.Point(358, 151);
            this.idStyleTextBox.Name = "idStyleTextBox";
            this.idStyleTextBox.Size = new System.Drawing.Size(100, 20);
            this.idStyleTextBox.TabIndex = 9;
            // 
            // nomCompositeurLabel
            // 
            nomCompositeurLabel.AutoSize = true;
            nomCompositeurLabel.Location = new System.Drawing.Point(246, 180);
            nomCompositeurLabel.Name = "nomCompositeurLabel";
            nomCompositeurLabel.Size = new System.Drawing.Size(91, 13);
            nomCompositeurLabel.TabIndex = 10;
            nomCompositeurLabel.Text = "nom Compositeur:";
            // 
            // nomCompositeurTextBox
            // 
            this.nomCompositeurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "nomCompositeur", true));
            this.nomCompositeurTextBox.Location = new System.Drawing.Point(358, 177);
            this.nomCompositeurTextBox.Name = "nomCompositeurTextBox";
            this.nomCompositeurTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomCompositeurTextBox.TabIndex = 11;
            // 
            // prenomCompositeurLabel
            // 
            prenomCompositeurLabel.AutoSize = true;
            prenomCompositeurLabel.Location = new System.Drawing.Point(246, 206);
            prenomCompositeurLabel.Name = "prenomCompositeurLabel";
            prenomCompositeurLabel.Size = new System.Drawing.Size(106, 13);
            prenomCompositeurLabel.TabIndex = 12;
            prenomCompositeurLabel.Text = "prenom Compositeur:";
            // 
            // prenomCompositeurTextBox
            // 
            this.prenomCompositeurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "prenomCompositeur", true));
            this.prenomCompositeurTextBox.Location = new System.Drawing.Point(358, 203);
            this.prenomCompositeurTextBox.Name = "prenomCompositeurTextBox";
            this.prenomCompositeurTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomCompositeurTextBox.TabIndex = 13;
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Location = new System.Drawing.Point(246, 232);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(54, 13);
            remarqueLabel.TabIndex = 14;
            remarqueLabel.Text = "remarque:";
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "remarque", true));
            this.remarqueTextBox.Location = new System.Drawing.Point(358, 229);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.remarqueTextBox.TabIndex = 15;
            // 
            // idNationLabel1
            // 
            idNationLabel1.AutoSize = true;
            idNationLabel1.Location = new System.Drawing.Point(246, 292);
            idNationLabel1.Name = "idNationLabel1";
            idNationLabel1.Size = new System.Drawing.Size(52, 13);
            idNationLabel1.TabIndex = 16;
            idNationLabel1.Text = "id Nation:";
            // 
            // idNationTextBox1
            // 
            this.idNationTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "NATIONALITE.idNation", true));
            this.idNationTextBox1.Location = new System.Drawing.Point(306, 289);
            this.idNationTextBox1.Name = "idNationTextBox1";
            this.idNationTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idNationTextBox1.TabIndex = 17;
            // 
            // libNationLabel
            // 
            libNationLabel.AutoSize = true;
            libNationLabel.Location = new System.Drawing.Point(246, 318);
            libNationLabel.Name = "libNationLabel";
            libNationLabel.Size = new System.Drawing.Size(54, 13);
            libNationLabel.TabIndex = 18;
            libNationLabel.Text = "lib Nation:";
            // 
            // libNationTextBox
            // 
            this.libNationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "NATIONALITE.libNation", true));
            this.libNationTextBox.Location = new System.Drawing.Point(306, 315);
            this.libNationTextBox.Name = "libNationTextBox";
            this.libNationTextBox.Size = new System.Drawing.Size(100, 20);
            this.libNationTextBox.TabIndex = 19;
            // 
            // dateDebutLabel
            // 
            dateDebutLabel.AutoSize = true;
            dateDebutLabel.Location = new System.Drawing.Point(246, 378);
            dateDebutLabel.Name = "dateDebutLabel";
            dateDebutLabel.Size = new System.Drawing.Size(63, 13);
            dateDebutLabel.TabIndex = 20;
            dateDebutLabel.Text = "date Debut:";
            // 
            // dateDebutTextBox
            // 
            this.dateDebutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "STYLE.dateDebut", true));
            this.dateDebutTextBox.Location = new System.Drawing.Point(315, 375);
            this.dateDebutTextBox.Name = "dateDebutTextBox";
            this.dateDebutTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateDebutTextBox.TabIndex = 21;
            // 
            // dateFinLabel
            // 
            dateFinLabel.AutoSize = true;
            dateFinLabel.Location = new System.Drawing.Point(246, 404);
            dateFinLabel.Name = "dateFinLabel";
            dateFinLabel.Size = new System.Drawing.Size(48, 13);
            dateFinLabel.TabIndex = 22;
            dateFinLabel.Text = "date Fin:";
            // 
            // dateFinTextBox
            // 
            this.dateFinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "STYLE.dateFin", true));
            this.dateFinTextBox.Location = new System.Drawing.Point(315, 401);
            this.dateFinTextBox.Name = "dateFinTextBox";
            this.dateFinTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateFinTextBox.TabIndex = 23;
            // 
            // idStyleLabel1
            // 
            idStyleLabel1.AutoSize = true;
            idStyleLabel1.Location = new System.Drawing.Point(246, 430);
            idStyleLabel1.Name = "idStyleLabel1";
            idStyleLabel1.Size = new System.Drawing.Size(44, 13);
            idStyleLabel1.TabIndex = 24;
            idStyleLabel1.Text = "id Style:";
            // 
            // idStyleTextBox1
            // 
            this.idStyleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "STYLE.idStyle", true));
            this.idStyleTextBox1.Location = new System.Drawing.Point(315, 427);
            this.idStyleTextBox1.Name = "idStyleTextBox1";
            this.idStyleTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idStyleTextBox1.TabIndex = 25;
            // 
            // libStyleLabel
            // 
            libStyleLabel.AutoSize = true;
            libStyleLabel.Location = new System.Drawing.Point(246, 456);
            libStyleLabel.Name = "libStyleLabel";
            libStyleLabel.Size = new System.Drawing.Size(46, 13);
            libStyleLabel.TabIndex = 26;
            libStyleLabel.Text = "lib Style:";
            // 
            // libStyleTextBox
            // 
            this.libStyleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPOSITEURBindingSource, "STYLE.libStyle", true));
            this.libStyleTextBox.Location = new System.Drawing.Point(315, 453);
            this.libStyleTextBox.Name = "libStyleTextBox";
            this.libStyleTextBox.Size = new System.Drawing.Size(100, 20);
            this.libStyleTextBox.TabIndex = 27;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(dateDebutLabel);
            this.Controls.Add(this.dateDebutTextBox);
            this.Controls.Add(dateFinLabel);
            this.Controls.Add(this.dateFinTextBox);
            this.Controls.Add(idStyleLabel1);
            this.Controls.Add(this.idStyleTextBox1);
            this.Controls.Add(libStyleLabel);
            this.Controls.Add(this.libStyleTextBox);
            this.Controls.Add(idNationLabel1);
            this.Controls.Add(this.idNationTextBox1);
            this.Controls.Add(libNationLabel);
            this.Controls.Add(this.libNationTextBox);
            this.Controls.Add(anMortLabel);
            this.Controls.Add(this.anMortTextBox);
            this.Controls.Add(anNaisLabel);
            this.Controls.Add(this.anNaisTextBox);
            this.Controls.Add(idCompositeurLabel);
            this.Controls.Add(this.idCompositeurTextBox);
            this.Controls.Add(idNationLabel);
            this.Controls.Add(this.idNationTextBox);
            this.Controls.Add(idStyleLabel);
            this.Controls.Add(this.idStyleTextBox);
            this.Controls.Add(nomCompositeurLabel);
            this.Controls.Add(this.nomCompositeurTextBox);
            this.Controls.Add(prenomCompositeurLabel);
            this.Controls.Add(this.prenomCompositeurTextBox);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Name = "test";
            this.Text = "test";
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSITEURBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cOMPOSITEURBindingSource;
        private System.Windows.Forms.TextBox anMortTextBox;
        private System.Windows.Forms.TextBox anNaisTextBox;
        private System.Windows.Forms.TextBox idCompositeurTextBox;
        private System.Windows.Forms.TextBox idNationTextBox;
        private System.Windows.Forms.TextBox idStyleTextBox;
        private System.Windows.Forms.TextBox nomCompositeurTextBox;
        private System.Windows.Forms.TextBox prenomCompositeurTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.TextBox idNationTextBox1;
        private System.Windows.Forms.TextBox libNationTextBox;
        private System.Windows.Forms.TextBox dateDebutTextBox;
        private System.Windows.Forms.TextBox dateFinTextBox;
        private System.Windows.Forms.TextBox idStyleTextBox1;
        private System.Windows.Forms.TextBox libStyleTextBox;
    }
}