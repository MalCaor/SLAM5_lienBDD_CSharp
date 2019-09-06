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
            /* le  bindingSource  bsVille est connecté à la table Ville de la BDD  via la chaîne de connexion */
            bsVille.DataSource = Modele.listeville();
        }

        private void VILLEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
