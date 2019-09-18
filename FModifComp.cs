using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLAM5_lienBDD_CSharp
{
    public partial class FModifComp : Form
    {
        public FModifComp()
        {
            InitializeComponent();
        }

        private void FAjoutComp_Load(object sender, EventArgs e)
        {
            COMPOSITEUR comptemp = Modele.lecompoChoisi;
            // Les Styles
            cbstyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cbstyle.DisplayMember = "libStyle";
            bsstyle.DataSource = Modele.listestyle();
            cbstyle.DataSource = bsstyle;
            // Les Nations
            cbnat.ValueMember = "idNation";//permet de stocker l'identifiant
            cbnat.DisplayMember = "libNation";
            bsnat.DataSource = Modele.listenat();
            cbnat.DataSource = bsnat;
            // Les infos
            tbnom.Text = comptemp.nomCompositeur;
            tbprenom.Text = comptemp.prenomCompositeur;
            tbmort.Text = (comptemp.anMort).ToString();
            tbnais.Text = (comptemp.anNais).ToString();
            rtbRemarque.Text = (comptemp.remarque).ToString();
        }

        private void Tbnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOk_Click(object sender, EventArgs e)
        {
            // appli Modif
            Modele.lecompoChoisi.anMort = int.Parse(tbmort.Text);
            Modele.lecompoChoisi.anNais = int.Parse(tbnais.Text);
            Modele.lecompoChoisi.remarque = rtbRemarque.Text;
            Modele.lecompoChoisi.nomCompositeur = tbnom.Text;
            Modele.lecompoChoisi.prenomCompositeur = tbprenom.Text;
            Modele.savechange();

            MessageBox.Show("Coucou c'est modifié ^^");
        }
    }
}
