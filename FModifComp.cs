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
    }
}
