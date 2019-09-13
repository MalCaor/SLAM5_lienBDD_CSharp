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
    public partial class FCompositeurOeuvre : Form
    {
        public FCompositeurOeuvre()
        {
            InitializeComponent();
            //les Compositeur
            bscomp.DataSource = Modele.listecomp();
            dgvCompStyle.DataSource = bscomp.DataSource;
            dgvCompStyle.Columns[0].Visible = false;
            dgvCompStyle.Columns[1].Visible = false;
            dgvCompStyle.Columns[2].Visible = false;
            dgvCompStyle.Columns[5].Visible = false;
            dgvCompStyle.Columns[6].Visible = false;
            dgvCompStyle.Columns[7].Visible = false;
            dgvCompStyle.Columns[8].Visible = false;
            dgvCompStyle.Columns[9].Visible = false;
            dgvCompStyle.Columns[10].Visible = false;
        }

        private void FCompositeurOeuvre_Load(object sender, EventArgs e)
        {
            comboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            comboStyle.DisplayMember = "libStyle";
            bsstyle.DataSource = Modele.listestyle();
            comboStyle.DataSource = bsstyle;
        }

        private void Bsstyle_CurrentChanged(object sender, EventArgs e)
        {
            STYLE v = (STYLE)bsstyle.Current;
            bscomp.DataSource = v.COMPOSITEUR.ToList();
            dgvCompStyle.DataSource = bscomp;
            /*
            int x = v.idStyle;
            bscomp.DataSource = Modele.CompositeurParStyle(int.Parse(x.ToString()));
            dgvCompStyle.DataSource = bscomp;
            dgvCompStyle.Columns[0].HeaderText = "NOM";
            dgvCompStyle.Columns[1].HeaderText = "PRENOM";
            dgvCompStyle.Columns[2].HeaderText = "STYLE";
            dgvCompStyle.Columns[3].HeaderText = "Né le";
            dgvCompStyle.Columns[4].HeaderText = "Mort le";
            dgvCompStyle.Columns[5].HeaderText = "Informations";
            */
            tbdebstyle.Text = v.dateDebut.ToString();
            tbfinstyle.Text = v.dateFin.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Bscomp_CurrentChanged(object sender, EventArgs e)
        {
            COMPOSITEUR c = (COMPOSITEUR)bscomp.Current;
            //le libnation
            string libnation = c.NATIONALITE.libNation;
            tbNati.Text = libnation;
            // la nais et mort
            int mort = (int)c.anMort;
            int nais = (int)c.anNais;
            tbNais.Text = String.Concat(mort);
            tbDece.Text = String.Concat(nais);
            // nom prenom
            string nom = c.nomCompositeur;
            string prenom = c.prenomCompositeur;
            tbVouAveSelec.Text = nom + " " + prenom;
            // Style
            string style = c.STYLE.libStyle;
            tbStyle.Text = style;
            // Remarque
            string remarque = c.remarque;
            rtbDesc.Text = remarque;
            // les Oeuvres
            bsoeuvre.DataSource = c.OEUVRE.ToList();
            dgvOeuvre.DataSource = bsoeuvre;
        }
    }
}
