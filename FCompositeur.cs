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
    }
}
