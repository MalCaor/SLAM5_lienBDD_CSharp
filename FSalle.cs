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
    public partial class FSalle : Form
    {
        public FSalle()
        {
            InitializeComponent();
            //les Salles
            bssalle.DataSource = Modele.listesalles();
            dgvsalle.DataSource = bssalle.DataSource;
            dgvsalle.Columns[5].Visible = false;
            dgvsalle.Columns[6].Visible = false;

            dgvsalle.Columns[0].HeaderText="numéro";

        }
    }
}
