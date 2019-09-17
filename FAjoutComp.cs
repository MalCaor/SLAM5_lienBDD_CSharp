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
    public partial class FAjoutComp : Form
    {
        public FAjoutComp()
        {
            InitializeComponent();
        }

        private void FAjoutComp_Load(object sender, EventArgs e)
        {
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
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            // Verif
            if (Control() == false)
            {
                MessageBox.Show("erreur");
            }
            else
            {
                // init var
                string nom = tbnom.Text;
                string prenom = tbprenom.Text;
                string remarque = rtbRemarque.Text;
                int anmort = int.Parse(tbmort.Text);
                int annais = int.Parse(tbnais.Text);
                int nati = ((NATIONALITE)bsnat.Current).idNation;
                int style = ((STYLE)bsstyle.Current).idStyle;
                // Crée Comp
                COMPOSITEUR newComp = new COMPOSITEUR();
                newComp.nomCompositeur = nom;
                newComp.prenomCompositeur = prenom;
                newComp.remarque = remarque;
                newComp.anMort = anmort;
                newComp.anNais = annais;
                newComp.idNation = nati;
                newComp.idStyle = style;
                Modele.ajoutCompo(newComp);
                //Messagebox
                MessageBox.Show("Compositeur Crée");
            }
            
        }

        private bool Control()
        {
            if ((string)tbnom.Text == "" && (string)tbprenom.Text == "" && (string)rtbRemarque.Text == "" && int.Parse(tbmort.Text) <= int.Parse(tbnais.Text))
            {
                return false;
            }
            return true;
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
