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
    public partial class FVille : Form
    {
        public FVille()
        {
            InitializeComponent();
            //les Villes
            bsVille.DataSource = Modele.listeville();
            dgvville.DataSource = bsVille.DataSource;
            //les Salles
            bssalle.DataSource = Modele.listesalles();
            dgvsalle.DataSource = bssalle.DataSource;
            //les batiments
            bsbat.DataSource = Modele.listebati();
            dgvbat.DataSource = bsbat.DataSource;
            //les oeuvres
            bstoeuvre.DataSource = Modele.listetypoeuvre();
            dgvtoeuvre.DataSource = bstoeuvre.DataSource;
        }

        private void VILLEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
