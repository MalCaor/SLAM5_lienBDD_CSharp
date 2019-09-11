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
    public partial class FCompositeurStyle : Form
    {
        public FCompositeurStyle()
        {
            InitializeComponent();
            //les Compositeur
            bscomp.DataSource = Modele.listecomp();
            dgvCompStyle.DataSource = bscomp.DataSource;
            dgvCompStyle.Columns[0].Visible = false;
            dgvCompStyle.Columns[1].Visible = false;
            dgvCompStyle.Columns[2].Visible = false;
            dgvCompStyle.Columns[8].Visible = false;
            dgvCompStyle.Columns[9].Visible = false;
            dgvCompStyle.Columns[10].Visible = false;
        }

        private void FCompositeurStyle_Load(object sender, EventArgs e)
        {
            comboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            comboStyle.DisplayMember = "libStyle";
            bsstyle.DataSource = Modele.listestyle();
            comboStyle.DataSource = bsstyle;
        }

        private void Bsstyle_CurrentChanged(object sender, EventArgs e)
        {
            STYLE v = (STYLE)bsstyle.Current;
            int x = v.idStyle;
            bscomp.DataSource = Modele.CompositeurParStyle(int.Parse(x.ToString()));
            dgvCompStyle.DataSource = bscomp;
            dgvCompStyle.Columns[0].HeaderText = "NOM";
            dgvCompStyle.Columns[1].HeaderText = "PRENOM";
            dgvCompStyle.Columns[2].HeaderText = "STYLE";
            dgvCompStyle.Columns[3].HeaderText = "Né le";
            dgvCompStyle.Columns[4].HeaderText = "Mort le";
            dgvCompStyle.Columns[5].HeaderText = "Informations";
            tbdebstyle.Text = v.dateDebut.ToString();
            tbfinstyle.Text = v.dateFin.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
