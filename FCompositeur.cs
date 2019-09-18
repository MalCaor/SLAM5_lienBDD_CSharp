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
    public partial class FCompositeurNation : Form
    {
        private  bool close = false;
        public FCompositeurNation()
        {
            InitializeComponent();
            //les Compositeur
            bsComp.DataSource = Modele.listecomp();
            dgvComp.DataSource = bsComp.DataSource;
            dgvComp.Columns[0].Visible = false;
            dgvComp.Columns[1].Visible = false;
            dgvComp.Columns[2].Visible = false;
            dgvComp.Columns[8].Visible = false;
            dgvComp.Columns[9].Visible = false;
            dgvComp.Columns[10].Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (close)
            {

            }
            else
            {
                bsComp.DataSource = Modele.CompositeurParNationalite(int.Parse(comboCompNat.SelectedValue.ToString()));
                dgvComp.DataSource = bsComp;
                dgvComp.Columns[0].HeaderText = "NOM";
                dgvComp.Columns[1].HeaderText = "PRENOM";
                dgvComp.Columns[2].HeaderText = "STYLE";
                dgvComp.Columns[3].HeaderText = "Né le";
                dgvComp.Columns[4].HeaderText = "Mort le";
                dgvComp.Columns[5].HeaderText = "Informations";
            }
            */
        }

        private void FCompositeurNation_Load(object sender, EventArgs e)
        {
            comboCompNat.ValueMember = "idNation";//permet de stocker l'identifiant
            comboCompNat.DisplayMember = "libNation";
            bsnat.DataSource = Modele.listenat();
            comboCompNat.DataSource = bsnat;
            close = false;
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            NATIONALITE v = (NATIONALITE)bsnat.Current;
            int x = v.idNation;
            bsComp.DataSource = Modele.CompositeurParNationalite(int.Parse(x.ToString()));
            dgvComp.DataSource = bsComp;
            dgvComp.Columns[0].HeaderText = "NOM";
            dgvComp.Columns[1].HeaderText = "PRENOM";
            dgvComp.Columns[2].HeaderText = "STYLE";
            dgvComp.Columns[3].HeaderText = "Né le";
            dgvComp.Columns[4].HeaderText = "Mort le";
            dgvComp.Columns[5].HeaderText = "Informations";

        }

        private void FCompositeurNation_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
        }

        private void BsComp_CurrentChanged(object sender, EventArgs e)
        {
            //COMPOSITEUR c = (COMPOSITEUR)bsComp.Current;
        }

        private void BAjout_Click(object sender, EventArgs e)
        {
            Form fajout = new FAjoutComp();
            fajout.ShowDialog();
           

        }

        private void BModif_Click(object sender, EventArgs e)
        {
            
            System.Type type = bsComp.Current.GetType();
            var id = (int)type.GetProperty("idCompositeur").GetValue(bsComp.Current, null);
            Modele.trouveCompositeurId(id);
            Form fmodif = new FModifComp();
            fmodif.ShowDialog();
        }

        private void DgvComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BSuppr_Click(object sender, EventArgs e)
        {
            System.Type type = bsComp.Current.GetType();
            var id = (int)type.GetProperty("idCompositeur").GetValue(bsComp.Current, null);
            Modele.SupprCompparID(id);
            MessageBox.Show("Comp Supprimé");
        }

        private void FCompositeurNation_Activated(object sender, EventArgs e)
        {
            NATIONALITE vcurrent = (NATIONALITE)bsnat.Current;
            bsnat.MoveFirst(); bsnat.MoveLast();
            comboCompNat.Text = vcurrent.libNation;
        }
    }
}
