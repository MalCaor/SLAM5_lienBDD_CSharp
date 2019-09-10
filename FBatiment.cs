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
    public partial class FBatiment : Form
    {
        public FBatiment()
        {
            InitializeComponent();
            //les Batiments
            bsbat.DataSource = Modele.listebati();
            dgvbat.DataSource = bsbat.DataSource;
            dgvbat.Columns[3].Visible = false;
            dgvbat.Columns[4].Visible = false;
            dgvbat.Columns[5].Visible = false;
            dgvbat.Columns[8].Visible = false;
            dgvbat.Columns[9].Visible = false;
        }

        private void Bsbat_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
