namespace SLAM5_lienBDD_CSharp
{
    partial class FMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.villeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOeuveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salleToolStripMenuItem,
            this.villeToolStripMenuItem,
            this.batimentToolStripMenuItem,
            this.typeOeuveToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem1.Text = "LIST";
            // 
            // salleToolStripMenuItem
            // 
            this.salleToolStripMenuItem.Name = "salleToolStripMenuItem";
            this.salleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salleToolStripMenuItem.Text = "Salle";
            this.salleToolStripMenuItem.Click += new System.EventHandler(this.SalleToolStripMenuItem_Click);
            // 
            // villeToolStripMenuItem
            // 
            this.villeToolStripMenuItem.Name = "villeToolStripMenuItem";
            this.villeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.villeToolStripMenuItem.Text = "Ville";
            this.villeToolStripMenuItem.Click += new System.EventHandler(this.VilleToolStripMenuItem_Click);
            // 
            // batimentToolStripMenuItem
            // 
            this.batimentToolStripMenuItem.Name = "batimentToolStripMenuItem";
            this.batimentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.batimentToolStripMenuItem.Text = "Batiment";
            this.batimentToolStripMenuItem.Click += new System.EventHandler(this.BatimentToolStripMenuItem_Click);
            // 
            // typeOeuveToolStripMenuItem
            // 
            this.typeOeuveToolStripMenuItem.Name = "typeOeuveToolStripMenuItem";
            this.typeOeuveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeOeuveToolStripMenuItem.Text = "Type Oeuve";
            this.typeOeuveToolStripMenuItem.Click += new System.EventHandler(this.TypeOeuveToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folle-journee.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SLAM5_lienBDD_CSharp.Properties.Resources.folle_journee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem villeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeOeuveToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

